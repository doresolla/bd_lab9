using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace lab9
{
    public partial class DgvrsPeriod : Form
    {
        public DgvrsPeriod()
        {
            InitializeComponent();
            textBox1.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Создание и настройка диалога сохранения файла
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Word Documents (*.docx, *.doc)|*.docx;*.doc|All files (*.*)|*.*";
            saveFileDialog1.FileName = "Договоры (свои номера)";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Данное поле не может быть пустым", "Ошибка!");
                return;
            }

            if (!int.TryParse(textBox1.Text, out int dgvrNumber) || dgvrNumber < 0)
            {
                MessageBox.Show("Пожалуйста, введите положительное число в данное поле", "Ошибка!");
                return;
            }

            // Создание объекта приложения Word
            Word.Application wordApp = new Word.Application();

            try
            {
                // Создание нового документа
                Word.Document doc = wordApp.Documents.Add();

                // Добавление параграфа для текста с форматированием
                AddFormattedText(doc, $"{DateTime.Now.ToString("dd.MM.yyyy")}\n", Word.WdParagraphAlignment.wdAlignParagraphLeft);

                // Определение диапазона для добавления таблицы
                Word.Range range = doc.Range();

                // Добавление заголовка таблицы
                AddFormattedText(doc, "Номер\tДата заключения\tКоличество\tСумма поставки\n", Word.WdParagraphAlignment.wdAlignParagraphCenter, true);

                // Создание таблицы с четырьмя столбцами
                range.Collapse(Word.WdCollapseDirection.wdCollapseEnd); // Перемещение курсора в конец диапазона
                Word.Table table = doc.Tables.Add(range, 1, 4); // Добавление таблицы к объекту Range

                // Скрытие границ таблицы
                table.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleNone;
                table.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleNone;

                // Установка ширины столбцов (в пунктах)
                table.Columns[1].SetWidth(75, Word.WdRulerStyle.wdAdjustProportional);
                table.Columns[2].SetWidth(150, Word.WdRulerStyle.wdAdjustProportional);
                table.Columns[3].SetWidth(90, Word.WdRulerStyle.wdAdjustProportional);
                table.Columns[4].SetWidth(150, Word.WdRulerStyle.wdAdjustProportional);


                // Выравнивание содержимого ячеек по центру
                table.Rows.Alignment = Word.WdRowAlignment.wdAlignRowCenter;

                string connectionString = "integrated security=SSPI;data source=\".\"; persist security info=False; initial catalog=Delivery_Ochirma";
                string storedProcedureName = "dbo.sp_dgvr_sum1";

                int rowIndex = 1; // Начнем заполнять таблицу со второй строки
                int Quantity = 0; //Количество
                float Delivery_amount = 0; //Сумма поставки

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(storedProcedureName, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        SqlParameter parameter = new SqlParameter("@dgvrNumber", SqlDbType.Int); // Указываем тип параметра (в данном случае int)
                        parameter.Value = int.Parse(textBox1.Text); // Задаем значение переменной dgvrNumber
                        command.Parameters.Add(parameter); // Добавляем параметр к команде

                        connection.Open();

                        // Выполнение процедуры и получение результата
                        SqlDataReader reader = command.ExecuteReader();

                        // Обработка результатов выполнения процедуры
                        while (reader.Read())
                        {
                            // Заполнение ячеек таблицы данными из базы данных
                            table.Rows.Add(); // Добавление новой строки в таблицу
                                              // Применение форматирования к ячейкам таблицы
                            FormatTableCell(table.Cell(rowIndex, 1), reader["НомерДоговора"].ToString(), Word.WdParagraphAlignment.wdAlignParagraphCenter, false);
                            FormatTableCell(table.Cell(rowIndex, 2), reader["ДатаДоговора"].ToString(), Word.WdParagraphAlignment.wdAlignParagraphCenter, false);
                            FormatTableCell(table.Cell(rowIndex, 3), reader["Количество"].ToString(), Word.WdParagraphAlignment.wdAlignParagraphCenter, false);
                            FormatTableCell(table.Cell(rowIndex, 4), reader["СуммаПоставки"].ToString(), Word.WdParagraphAlignment.wdAlignParagraphCenter, false);

                            rowIndex++; // Увеличение индекса строки
                            if (!string.IsNullOrEmpty(reader["Количество"].ToString()))
                                Quantity += int.Parse(reader["Количество"].ToString());
                            if (!string.IsNullOrEmpty(reader["СуммаПоставки"].ToString()))
                                Delivery_amount += float.Parse(reader["СуммаПоставки"].ToString());
                        }

                        reader.Close();
                    }
                }

                // Добавление горизонтальной черты
                Word.Paragraph horizontalLineParagraph = doc.Paragraphs.Add();
                Word.Range horizontalLineRange = horizontalLineParagraph.Range;
                horizontalLineRange.Borders[Word.WdBorderType.wdBorderBottom].LineStyle = Word.WdLineStyle.wdLineStyleSingle;
                horizontalLineRange.Borders[Word.WdBorderType.wdBorderBottom].LineWidth = Word.WdLineWidth.wdLineWidth050pt;
                horizontalLineRange.Borders[Word.WdBorderType.wdBorderBottom].Color = Word.WdColor.wdColorBlack;

                Word.Range range2 = doc.Range();
                // Создание таблицы с четырьмя столбцами
                range2.Collapse(Word.WdCollapseDirection.wdCollapseEnd); // Перемещение курсора в конец диапазона
                Word.Table table2 = doc.Tables.Add(range2, 1, 4); // Добавление таблицы к объекту Range

                // Скрытие границ таблицы
                table2.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleNone;
                table2.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleNone;

                // Установка ширины столбцов (в пунктах)
                table2.Columns[1].SetWidth(75, Word.WdRulerStyle.wdAdjustProportional);
                table2.Columns[2].SetWidth(150, Word.WdRulerStyle.wdAdjustProportional);
                table2.Columns[3].SetWidth(90, Word.WdRulerStyle.wdAdjustProportional);
                table2.Columns[4].SetWidth(150, Word.WdRulerStyle.wdAdjustProportional);

                // Заполнение ячеек таблицы
                // Применение форматирования к ячейкам таблицы
                FormatTableCell(table2.Cell(1, 1), (rowIndex - 1).ToString(), Word.WdParagraphAlignment.wdAlignParagraphCenter, false);
                FormatTableCell(table2.Cell(1, 2), "", Word.WdParagraphAlignment.wdAlignParagraphCenter, false);
                FormatTableCell(table2.Cell(1, 3), Quantity.ToString(), Word.WdParagraphAlignment.wdAlignParagraphCenter, false);
                FormatTableCell(table2.Cell(1, 4), Delivery_amount.ToString(), Word.WdParagraphAlignment.wdAlignParagraphCenter, false);



                // Сохранение документа и закрытие приложения Word
                doc.SaveAs(saveFileDialog1.FileName);
                doc.Close();
            }
            finally
            {
                // Завершение приложения Word
                wordApp.Quit();
                MessageBox.Show("Отчёт сформирован");
            }
        }

        private void FormatTableCell(Word.Cell cell, string text, Word.WdParagraphAlignment alignment, bool isBold = false)
        {
            Word.Range range = cell.Range;
            range.Text = text;
            range.Font.Name = "Times New Roman";
            range.Font.Size = 14;
            range.Font.Bold = isBold ? 1 : 0;
            range.Font.Italic = 0;
            range.Font.Color = Word.WdColor.wdColorBlack;
            range.ParagraphFormat.Alignment = alignment;
            if (isBold)
            {
                range.Font.Underline = Word.WdUnderline.wdUnderlineSingle;
            }
        }

        // Метод для добавления форматированного текста в документ Word
        private void AddFormattedText(Word.Document doc, string text, Word.WdParagraphAlignment alignment, bool isBold = false)
        {
            Word.Paragraph para = doc.Paragraphs.Add();
            Word.Range range = para.Range;

            range.Text = text;
            range.Font.Name = "Times New Roman";
            range.Font.Size = 14;
            range.Font.Bold = isBold ? 1 : 0;
            range.Font.Italic = 0;
            range.Font.Color = Word.WdColor.wdColorBlack;
            range.ParagraphFormat.Alignment = alignment;
            if (isBold)
            {
                range.Font.Underline = Word.WdUnderline.wdUnderlineSingle;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Создание и настройка диалога сохранения файла
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Word Documents (*.docx, *.doc)|*.docx;*.doc|All files (*.*)|*.*";
            saveFileDialog1.FileName = "Договоры (в течение периода)";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            // Создание объекта приложения Word
            Word.Application wordApp = new Word.Application();

            try
            {
                // Создание нового документа
                Word.Document doc = wordApp.Documents.Add();

                // Добавление параграфа для текста с форматированием
                AddFormattedText(doc, $"{DateTime.Now.ToString("dd.MM.yyyy")}\n", Word.WdParagraphAlignment.wdAlignParagraphLeft);

                // Определение диапазона для добавления таблицы
                Word.Range range = doc.Range();

                // Добавление заголовка таблицы
                AddFormattedText(doc, "Номер\tДата заключения\tКоличество\tСумма поставки\n", Word.WdParagraphAlignment.wdAlignParagraphCenter, true);

                // Создание таблицы с четырьмя столбцами
                range.Collapse(Word.WdCollapseDirection.wdCollapseEnd); // Перемещение курсора в конец диапазона
                Word.Table table = doc.Tables.Add(range, 1, 4); // Добавление таблицы к объекту Range

                // Скрытие границ таблицы
                table.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleNone;
                table.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleNone;

                // Установка ширины столбцов (в пунктах)
                table.Columns[1].SetWidth(75, Word.WdRulerStyle.wdAdjustProportional);
                table.Columns[2].SetWidth(150, Word.WdRulerStyle.wdAdjustProportional);
                table.Columns[3].SetWidth(90, Word.WdRulerStyle.wdAdjustProportional);
                table.Columns[4].SetWidth(150, Word.WdRulerStyle.wdAdjustProportional);


                // Выравнивание содержимого ячеек по центру
                table.Rows.Alignment = Word.WdRowAlignment.wdAlignRowCenter;

                string connectionString = "integrated security=SSPI;data source=\".\"; persist security info=False; initial catalog=Delivery_Ochirma";
                string storedProcedureName = "dbo.sp_dgvr_agr";

                int rowIndex = 1; // Начнем заполнять таблицу со второй строки
                int Quantity = 0; //Количество
                float Delivery_amount = 0; //Сумма поставки

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(storedProcedureName, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        SqlParameter parameter = new SqlParameter("@var1", SqlDbType.DateTime); // Указываем тип параметра (в данном случае int)
                        parameter.Value = dateTimePicker1.Value; // Задаем значение переменной dgvrNumber
                        command.Parameters.Add(parameter); // Добавляем параметр к команде

                        SqlParameter parameter2 = new SqlParameter("@var2", SqlDbType.DateTime); // Указываем тип параметра (в данном случае int)
                        parameter2.Value = dateTimePicker2.Value; // Задаем значение переменной dgvrNumber
                        command.Parameters.Add(parameter2); // Добавляем параметр к команде

                        connection.Open();

                        // Выполнение процедуры и получение результата
                        SqlDataReader reader = command.ExecuteReader();

                        // Обработка результатов выполнения процедуры
                        while (reader.Read())
                        {
                            // Заполнение ячеек таблицы данными из базы данных
                            table.Rows.Add(); // Добавление новой строки в таблицу
                                              // Применение форматирования к ячейкам таблицы
                            FormatTableCell(table.Cell(rowIndex, 1), reader["НомерДоговора"].ToString(), Word.WdParagraphAlignment.wdAlignParagraphCenter, false);
                            FormatTableCell(table.Cell(rowIndex, 2), reader["ДатаДоговора"].ToString(), Word.WdParagraphAlignment.wdAlignParagraphCenter, false);
                            FormatTableCell(table.Cell(rowIndex, 3), reader["Количество"].ToString(), Word.WdParagraphAlignment.wdAlignParagraphCenter, false);
                            FormatTableCell(table.Cell(rowIndex, 4), reader["СуммаПоставки"].ToString(), Word.WdParagraphAlignment.wdAlignParagraphCenter, false);

                            rowIndex++; // Увеличение индекса строки
                            if (!string.IsNullOrEmpty(reader["Количество"].ToString()))
                                Quantity += int.Parse(reader["Количество"].ToString());
                            if (!string.IsNullOrEmpty(reader["СуммаПоставки"].ToString()))
                                Delivery_amount += float.Parse(reader["СуммаПоставки"].ToString());
                        }

                        reader.Close();
                    }
                }

                // Добавление горизонтальной черты
                Word.Paragraph horizontalLineParagraph = doc.Paragraphs.Add();
                Word.Range horizontalLineRange = horizontalLineParagraph.Range;
                horizontalLineRange.Borders[Word.WdBorderType.wdBorderBottom].LineStyle = Word.WdLineStyle.wdLineStyleSingle;
                horizontalLineRange.Borders[Word.WdBorderType.wdBorderBottom].LineWidth = Word.WdLineWidth.wdLineWidth050pt;
                horizontalLineRange.Borders[Word.WdBorderType.wdBorderBottom].Color = Word.WdColor.wdColorBlack;

                Word.Range range2 = doc.Range();
                // Создание таблицы с четырьмя столбцами
                range2.Collapse(Word.WdCollapseDirection.wdCollapseEnd); // Перемещение курсора в конец диапазона
                Word.Table table2 = doc.Tables.Add(range2, 1, 4); // Добавление таблицы к объекту Range

                // Скрытие границ таблицы
                table2.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleNone;
                table2.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleNone;

                // Установка ширины столбцов (в пунктах)
                table2.Columns[1].SetWidth(75, Word.WdRulerStyle.wdAdjustProportional);
                table2.Columns[2].SetWidth(150, Word.WdRulerStyle.wdAdjustProportional);
                table2.Columns[3].SetWidth(90, Word.WdRulerStyle.wdAdjustProportional);
                table2.Columns[4].SetWidth(150, Word.WdRulerStyle.wdAdjustProportional);

                // Заполнение ячеек таблицы
                // Применение форматирования к ячейкам таблицы
                FormatTableCell(table2.Cell(1, 1), (rowIndex - 1).ToString(), Word.WdParagraphAlignment.wdAlignParagraphCenter, false);
                FormatTableCell(table2.Cell(1, 2), "", Word.WdParagraphAlignment.wdAlignParagraphCenter, false);
                FormatTableCell(table2.Cell(1, 3), Quantity.ToString(), Word.WdParagraphAlignment.wdAlignParagraphCenter, false);
                FormatTableCell(table2.Cell(1, 4), Delivery_amount.ToString(), Word.WdParagraphAlignment.wdAlignParagraphCenter, false);



                // Сохранение документа и закрытие приложения Word
                doc.SaveAs(saveFileDialog1.FileName);
                doc.Close();
            }
            finally
            {
                // Завершение приложения Word
                wordApp.Quit();
                MessageBox.Show("Отчёт сформирован");
            }
        }
    }
}
