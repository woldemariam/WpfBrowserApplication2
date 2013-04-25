using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Web;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Web.Hosting;
using System.Diagnostics;
using System.Net;
using System.Json;

namespace WpfBrowserApplication1
{
    /// <summary>
    /// Interaction logic for Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        string selected = "";
        string selected2 = "";
        public Page3()
        {
            InitializeComponent();
            user.Content = "LOGGED IN AS: "+App.Current.Properties["user"];
        }

        private void Checked(object sender, RoutedEventArgs e)
        {
            selected += ((CheckBox)sender).Content+"\n";
            selected2 += ((CheckBox)sender).Content + ", ";
        }

        private void UnChecked(object sender, RoutedEventArgs e)
        {
            CheckBox myWpfButton = (CheckBox)sender;
        }

   
        private void txt_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void txt_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Print_Receipt(object sender, RoutedEventArgs e)
        {
            var doc1 = new Document();

            string path = System.AppDomain.CurrentDomain.BaseDirectory;
            PdfWriter.GetInstance(doc1, new FileStream(path+"/Doc1.pdf", FileMode.Create));

          

            doc1.Open();

            doc1.Add(new iTextSharp.text.Paragraph(DateTime.Now.ToString()));
            doc1.Add(new iTextSharp.text.Paragraph(" "));

            PdfPTable table = new PdfPTable(2);
            PdfPCell cell = new PdfPCell(new Phrase("Beverly Hill Online Grocery Services"));
            table.DefaultCell.Border = 0;
            table.TotalWidth = 170;
            table.HorizontalAlignment = 0;

            cell.Colspan = 2;
            cell.PaddingBottom = 10;
            cell.Border = 0;
            cell.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase(selected));
            cell.PaddingBottom = 10;
            cell.Border = 0;
            cell.Colspan = 2;
            cell.HorizontalAlignment = 0; 
            table.AddCell(cell);
            table.AddCell("Subtotal");
            table.AddCell(subtotal_1.Text);

            table.AddCell("Tax");
            table.AddCell(tax_1.Text);

            table.AddCell("Total");
            table.AddCell(total_1.Text);

            doc1.Add(table);
 

            doc1.Close();

            Process wordProcess = new Process();
            wordProcess.StartInfo.FileName = path + "/Doc1.pdf";
            wordProcess.StartInfo.UseShellExecute = true;
            wordProcess.Start();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            printBtn.Visibility = Visibility.Visible;

            decimal taxrate;
            decimal tax;
            decimal subtotal;
            decimal total;
            decimal num1;
            decimal num2;
            decimal num3;
            decimal num4;
            decimal num5;
            decimal num6;
            decimal num7;
            decimal num8;
            decimal num9;
            decimal num10;
            decimal num11;
            decimal num12;
            decimal num13;
            decimal num14;
            decimal num15;
            decimal num16;
            decimal num17;
            decimal num18;
            decimal num19;
            decimal num20;
            decimal num21;
            decimal num22;
            decimal num23;
            decimal num24;
            decimal num25;
            decimal num26;
            decimal num27;
            decimal num28;
            decimal num29;
            decimal num30;
            decimal num31;
            decimal num32;


            num1 = Convert.ToDecimal(txt1.Text);
            num2 = Convert.ToDecimal(txt2.Text);
            num3 = Convert.ToDecimal(txt3.Text);
            num4 = Convert.ToDecimal(txt4.Text);
            num5 = Convert.ToDecimal(txt5.Text);
            num6 = Convert.ToDecimal(txt6.Text);
            num7 = Convert.ToDecimal(txt7.Text);
            num8 = Convert.ToDecimal(txt8.Text);
            num9 = Convert.ToDecimal(txt9.Text);
            num10 = Convert.ToDecimal(txt10.Text);
            num11 = Convert.ToDecimal(txt11.Text);
            num12 = Convert.ToDecimal(txt12.Text);
            num13 = Convert.ToDecimal(txt13.Text);
            num14 = Convert.ToDecimal(txt14.Text);
            num15 = Convert.ToDecimal(txt15.Text);
            num16 = Convert.ToDecimal(txt16.Text);
            num17 = Convert.ToDecimal(txt17.Text);
            num18 = Convert.ToDecimal(txt18.Text);
            num19 = Convert.ToDecimal(txt19.Text);
            num20 = Convert.ToDecimal(txt20.Text);
            num21 = Convert.ToDecimal(txt21.Text);
            num22 = Convert.ToDecimal(txt22.Text);
            num23 = Convert.ToDecimal(txt23.Text);
            num24 = Convert.ToDecimal(txt24.Text);
            num25 = Convert.ToDecimal(txt25.Text);
            num26 = Convert.ToDecimal(txt26.Text);
            num27 = Convert.ToDecimal(txt27.Text);
            num28 = Convert.ToDecimal(txt28.Text);
            num29 = Convert.ToDecimal(txt29.Text);
            num30 = Convert.ToDecimal(txt30.Text);
            num31 = Convert.ToDecimal(txt31.Text);
            num32 = Convert.ToDecimal(txt32.Text);



            if (cb1.IsChecked == false)
            {
                num1 = 0;

                tax = 0.08m;
                subtotal = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10 + num11 + num12 + num13 + num14 + num15 + num16 + num17 + num18 + num19 + num20 + num21 + num22 + num23 + num24 + num25 + num26 + num27 + num28 + num29 + num30 + num31 + num32;
                taxrate = (subtotal * tax);
                total = subtotal + taxrate;
                subtotal_1.Text = subtotal.ToString("00.00");
                tax_1.Text = taxrate.ToString("00.00");
                total_1.Text = total.ToString("00.00");

            }
            else
            {
                num1 = 5.75m;

                tax = 0.08m;
                subtotal = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10 + num11 + num12 + num13 + num14 + num15 + num16 + num17 + num18 + num19 + num20 + num21 + num22 + num23 + num24 + num25 + num26 + num27 + num28 + num29 + num30 + num31 + num32;
                taxrate = (subtotal * tax);
                total = subtotal + taxrate;
                subtotal_1.Text = subtotal.ToString("00.00");
                tax_1.Text = taxrate.ToString("00.00");
                total_1.Text = total.ToString("00.00");

            }

            if (cb2.IsChecked == false)
            {
                num2 = 0;

                tax = 0.08m;
                subtotal = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10 + num11 + num12 + num13 + num14 + num15 + num16
                   + num17 + num18 + num19 + num20 + num21 + num22 + num23 + num24 + num25 + num26 + num27 + num28 + num29 + num30 + num31 + num32;
                taxrate = (subtotal * tax);
                total = subtotal + taxrate;
                subtotal_1.Text = subtotal.ToString("00.00");
                tax_1.Text = taxrate.ToString("00.00");
                total_1.Text = total.ToString("00.00");

            }
            else
            {
                num2 = 4.49m;

                tax = 0.08m;
                subtotal = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10 + num11 + num12 + num13 + num14 + num15 + num16
                        + num17 + num18 + num19 + num20 + num21 + num22 + num23 + num24 + num25 + num26 + num27 + num28 + num29 + num30 + num31 + num32;
                taxrate = (subtotal * tax);
                total = subtotal + taxrate;
                subtotal_1.Text = subtotal.ToString("00.00");
                tax_1.Text = taxrate.ToString("00.00");
                total_1.Text = total.ToString("00.00");

            }


            if (cb3.IsChecked == false)
            {
                num3 = 0;
                tax = 0.08m;
                subtotal = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10 + num11 + num12 + num13 + num14 + num15 + num16
                      + num17 + num18 + num19 + num20 + num21 + num22 + num23 + num24 + num25 + num26 + num27 + num28 + num29 + num30 + num31 + num32;
                taxrate = (subtotal * tax);
                total = subtotal + taxrate;
                subtotal_1.Text = subtotal.ToString("00.00");
                tax_1.Text = taxrate.ToString("00.00");
                total_1.Text = total.ToString("00.00");
            }
            else
            {
                num3 = 4.50m;

                tax = 0.08m;
                subtotal = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10 + num11 + num12 + num13 + num14 + num15 + num16
                     + num17 + num18 + num19 + num20 + num21 + num22 + num23 + num24 + num25 + num26 + num27 + num28 + num29 + num30 + num31 + num32;
                taxrate = (subtotal * tax);
                total = subtotal + taxrate;
                subtotal_1.Text = subtotal.ToString("00.00");
                tax_1.Text = taxrate.ToString("00.00");
                total_1.Text = total.ToString("00.00");
            }


            if (cb4.IsChecked == false)
            {
                num4 = 0;

                tax = 0.08m;
                subtotal = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10 + num11 + num12 + num13 + num14 + num15 + num16
                     + num17 + num18 + num19 + num20 + num21 + num22 + num23 + num24 + num25 + num26 + num27 + num28 + num29 + num30 + num31 + num32;
                taxrate = (subtotal * tax);
                total = subtotal + taxrate;
                subtotal_1.Text = subtotal.ToString("00.00");
                tax_1.Text = taxrate.ToString("00.00");
                total_1.Text = total.ToString("00.00");
            }
            else
            {
                num4 = 4.75m;

                tax = 0.08m;
                subtotal = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10 + num11 + num12 + num13 + num14 + num15 + num16
                          + num17 + num18 + num19 + num20 + num21 + num22 + num23 + num24 + num25 + num26 + num27 + num28 + num29 + num30 + num31 + num32;
                taxrate = (subtotal * tax);
                total = subtotal + taxrate;
                subtotal_1.Text = subtotal.ToString("00.00");
                tax_1.Text = taxrate.ToString("00.00");
                total_1.Text = total.ToString("00.00");
            }

            if (cb5.IsChecked == false)
            {
                num5 = 0;
                tax = 0.08m;
                subtotal = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10 + num11 + num12 + num13 + num14 + num15 + num16
                    + num17 + num18 + num19 + num20 + num21 + num22 + num23 + num24 + num25 + num26 + num27 + num28 + num29 + num30 + num31 + num32;
                taxrate = (subtotal * tax);
                total = subtotal + taxrate;
                subtotal_1.Text = subtotal.ToString("00.00");
                tax_1.Text = taxrate.ToString("00.00");
                total_1.Text = total.ToString("00.00");
            }
            else
            {
                num5 = 1.09m;

                tax = 0.08m;
                subtotal = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10 + num11 + num12 + num13 + num14 + num15 + num16
                     + num17 + num18 + num19 + num20 + num21 + num22 + num23 + num24 + num25 + num26 + num27 + num28 + num29 + num30 + num31 + num32;
                taxrate = (subtotal * tax);
                total = subtotal + taxrate;
                subtotal_1.Text = subtotal.ToString("00.00");
                tax_1.Text = taxrate.ToString("00.00");
                total_1.Text = total.ToString("00.00");
            }


            if (cb6.IsChecked == false)
            {
                num6 = 0;

                tax = 0.08m;
                subtotal = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10 + num11 + num12 + num13 + num14 + num15 + num16
                   + num17 + num18 + num19 + num20 + num21 + num22 + num23 + num24 + num25 + num26 + num27 + num28 + num29 + num30 + num31 + num32;
                taxrate = (subtotal * tax);
                total = subtotal + taxrate;
                subtotal_1.Text = subtotal.ToString("00.00");
                tax_1.Text = taxrate.ToString("00.00");
                total_1.Text = total.ToString("00.00");
            }
            else
            {
                num6 = 2.00m;
                tax = 0.08m;
                subtotal = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10 + num11 + num12 + num13 + num14 + num15 + num16
                      + num17 + num18 + num19 + num20 + num21 + num22 + num23 + num24 + num25 + num26 + num27 + num28 + num29 + num30 + num31 + num32;
                taxrate = (subtotal * tax);
                total = subtotal + taxrate;
                subtotal_1.Text = subtotal.ToString("00.00");
                tax_1.Text = taxrate.ToString("00.00");
                total_1.Text = total.ToString("00.00");
            }


            if (cb7.IsChecked == false)
            {
                num7 = 0;

                tax = 0.08m;
                subtotal = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10 + num11 + num12 + num13 + num14 + num15 + num16
                      + num17 + num18 + num19 + num20 + num21 + num22 + num23 + num24 + num25 + num26 + num27 + num28 + num29 + num30 + num31 + num32;
                taxrate = (subtotal * tax);
                total = subtotal + taxrate;
                subtotal_1.Text = subtotal.ToString("00.00");
                tax_1.Text = taxrate.ToString("00.00");
                total_1.Text = total.ToString("00.00");
            }
            else
            {
                num7 = 2.50m;

                tax = 0.08m;
                subtotal = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10 + num11 + num12 + num13 + num14 + num15 + num16
                   + num17 + num18 + num19 + num20 + num21 + num22 + num23 + num24 + num25 + num26 + num27 + num28 + num29 + num30 + num31 + num32;
                taxrate = (subtotal * tax);
                total = subtotal + taxrate;
                subtotal_1.Text = subtotal.ToString("00.00");
                tax_1.Text = taxrate.ToString("00.00");
                total_1.Text = total.ToString("00.00");
            }

            if (cb8.IsChecked == false)
            {
                num8 = 0;
                tax = 0.08m;
                subtotal = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10 + num11 + num12 + num13 + num14 + num15 + num16
                    + num17 + num18 + num19 + num20 + num21 + num22 + num23 + num24 + num25 + num26 + num27 + num28 + num29 + num30 + num31 + num32;
                taxrate = (subtotal * tax);
                total = subtotal + taxrate;
                subtotal_1.Text = subtotal.ToString("00.00");
                tax_1.Text = taxrate.ToString("00.00");
                total_1.Text = total.ToString("00.00");
            }
            else
            {
                num8 = 1.75m;

                tax = 0.08m;
                subtotal = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10 + num11 + num12 + num13 + num14 + num15 + num16
                    + num17 + num18 + num19 + num20 + num21 + num22 + num23 + num24 + num25 + num26 + num27 + num28 + num29 + num30 + num31 + num32;
                taxrate = (subtotal * tax);
                total = subtotal + taxrate;
                subtotal_1.Text = subtotal.ToString("00.00");
                tax_1.Text = taxrate.ToString("00.00");
                total_1.Text = total.ToString("00.00");
            }


            if (cb9.IsChecked == false)
            {
                num9 = 0;
                tax = 0.08m;
                subtotal = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10 + num11 + num12 + num13 + num14 + num15 + num16
                    + num17 + num18 + num19 + num20 + num21 + num22 + num23 + num24 + num25 + num26 + num27 + num28 + num29 + num30 + num31 + num32;
                taxrate = (subtotal * tax);
                total = subtotal + taxrate;
                subtotal_1.Text = subtotal.ToString("00.00");
                tax_1.Text = taxrate.ToString("00.00");
                total_1.Text = total.ToString("00.00");
            }
            else
            {
                num9 = 6.25m;

                tax = 0.08m;
                subtotal = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10 + num11 + num12 + num13 + num14 + num15 + num16
                   + num17 + num18 + num19 + num20 + num21 + num22 + num23 + num24 + num25 + num26 + num27 + num28 + num29 + num30 + num31 + num32;
                taxrate = (subtotal * tax);
                total = subtotal + taxrate;
                subtotal_1.Text = subtotal.ToString("00.00");
                tax_1.Text = taxrate.ToString("00.00");
                total_1.Text = total.ToString("00.00");
            }


            if (cb10.IsChecked == false)
            {
                num10 = 0;

                tax = 0.08m;
                subtotal = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10 + num11 + num12 + num13 + num14 + num15 + num16
                     + num17 + num18 + num19 + num20 + num21 + num22 + num23 + num24 + num25 + num26 + num27 + num28 + num29 + num30 + num31 + num32;
                taxrate = (subtotal * tax);
                total = subtotal + taxrate;
                subtotal_1.Text = subtotal.ToString("00.00");
                tax_1.Text = taxrate.ToString("00.00");
                total_1.Text = total.ToString("00.00");
            }
            else
            {
                num10 = 3.25m;
                tax = 0.08m;
                subtotal = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10 + num11 + num12 + num13 + num14 + num15 + num16
                    + num17 + num18 + num19 + num20 + num21 + num22 + num23 + num24 + num25 + num26 + num27 + num28 + num29 + num30 + num31 + num32;
                taxrate = (subtotal * tax);
                total = subtotal + taxrate;
                subtotal_1.Text = subtotal.ToString("00.00");
                tax_1.Text = taxrate.ToString("00.00");
                total_1.Text = total.ToString("00.00");
            }


            if (cb11.IsChecked == false)
            {
                num11 = 0;

                tax = 0.08m;
                subtotal = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10 + num11 + num12 + num13 + num14 + num15 + num16
                      + num17 + num18 + num19 + num20 + num21 + num22 + num23 + num24 + num25 + num26 + num27 + num28 + num29 + num30 + num31 + num32;
                taxrate = (subtotal * tax);
                total = subtotal + taxrate;
                subtotal_1.Text = subtotal.ToString("00.00");
                tax_1.Text = taxrate.ToString("00.00");
                total_1.Text = total.ToString("00.00");
            }
            else
            {
                num11 = 10.00m;

                tax = 0.08m;
                subtotal = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10 + num11 + num12 + num13 + num14 + num15 + num16
                     + num17 + num18 + num19 + num20 + num21 + num22 + num23 + num24 + num25 + num26 + num27 + num28 + num29 + num30 + num31 + num32;
                taxrate = (subtotal * tax);
                total = subtotal + taxrate;
                subtotal_1.Text = subtotal.ToString("00.00");
                tax_1.Text = taxrate.ToString("00.00");
                total_1.Text = total.ToString("00.00");
            }

            if (cb12.IsChecked == false)
            {
                num12 = 0;
                tax = 0.08m;
                subtotal = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10 + num11 + num12 + num13 + num14 + num15 + num16
                    + num17 + num18 + num19 + num20 + num21 + num22 + num23 + num24 + num25 + num26 + num27 + num28 + num29 + num30 + num31 + num32;
                taxrate = (subtotal * tax);
                total = subtotal + taxrate;
                subtotal_1.Text = subtotal.ToString("00.00");
                tax_1.Text = taxrate.ToString("00.00");
                total_1.Text = total.ToString("00.00");
            }
            else
            {
                num12 = 15.00m;

                tax = 0.08m;
                subtotal = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10 + num11 + num12 + num13 + num14 + num15 + num16
                   + num17 + num18 + num19 + num20 + num21 + num22 + num23 + num24 + num25 + num26 + num27 + num28 + num29 + num30 + num31 + num32;
                taxrate = (subtotal * tax);
                total = subtotal + taxrate;
                subtotal_1.Text = subtotal.ToString("00.00");
                tax_1.Text = taxrate.ToString("00.00");
                total_1.Text = total.ToString("00.00");
            }

            if (cb13.IsChecked == false)
            {
                num13 = 0;
                tax = 0.08m;
                subtotal = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10 + num11 + num12 + num13 + num14 + num15 + num16
                       + num17 + num18 + num19 + num20 + num21 + num22 + num23 + num24 + num25 + num26 + num27 + num28 + num29 + num30 + num31 + num32;
                taxrate = (subtotal * tax);
                total = subtotal + taxrate;
                subtotal_1.Text = subtotal.ToString("00.00");
                tax_1.Text = taxrate.ToString("00.00");
                total_1.Text = total.ToString("00.00");
            }
            else
            {
                num13 = 8.00m;

                tax = 0.08m;
                subtotal = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10 + num11 + num12 + num13 + num14 + num15 + num16
                   + num17 + num18 + num19 + num20 + num21 + num22 + num23 + num24 + num25 + num26 + num27 + num28 + num29 + num30 + num31 + num32;
                taxrate = (subtotal * tax);
                total = subtotal + taxrate;
                subtotal_1.Text = subtotal.ToString("00.00");
                tax_1.Text = taxrate.ToString("00.00");
                total_1.Text = total.ToString("00.00");
            }


            if (cb14.IsChecked == false)
            {
                num14 = 0;

                tax = 0.08m;
                subtotal = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10 + num11 + num12 + num13 + num14 + num15 + num16
                   + num17 + num18 + num19 + num20 + num21 + num22 + num23 + num24 + num25 + num26 + num27 + num28 + num29 + num30 + num31 + num32;
                taxrate = (subtotal * tax);
                total = subtotal + taxrate;
                subtotal_1.Text = subtotal.ToString("00.00");
                tax_1.Text = taxrate.ToString("00.00");
                total_1.Text = total.ToString("00.00");
            }
            else
            {
                num14 = 5.79m;
                tax = 0.08m;
                subtotal = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10 + num11 + num12 + num13 + num14 + num15 + num16
                   + num17 + num18 + num19 + num20 + num21 + num22 + num23 + num24 + num25 + num26 + num27 + num28 + num29 + num30 + num31 + num32;
                taxrate = (subtotal * tax);
                total = subtotal + taxrate;
                subtotal_1.Text = subtotal.ToString("00.00");
                tax_1.Text = taxrate.ToString("00.00");
                total_1.Text = total.ToString("00.00");
            }


            if (cb15.IsChecked == false)
            {
                num15 = 0;

                tax = 0.08m;
                subtotal = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10 + num11 + num12 + num13 + num14 + num15 + num16
                   + num17 + num18 + num19 + num20 + num21 + num22 + num23 + num24 + num25 + num26 + num27 + num28 + num29 + num30 + num31 + num32;
                taxrate = (subtotal * tax);
                total = subtotal + taxrate;
                subtotal_1.Text = subtotal.ToString("00.00");
                tax_1.Text = taxrate.ToString("00.00");
                total_1.Text = total.ToString("00.00");
            }
            else
            {
                num15 = 6.85m;

                tax = 0.08m;
                subtotal = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10 + num11 + num12 + num13 + num14 + num15 + num16
                     + num17 + num18 + num19 + num20 + num21 + num22 + num23 + num24 + num25 + num26 + num27 + num28 + num29 + num30 + num31 + num32;
                taxrate = (subtotal * tax);
                total = subtotal + taxrate;
                subtotal_1.Text = subtotal.ToString("00.00");
                tax_1.Text = taxrate.ToString("00.00");
                total_1.Text = total.ToString("00.00");
            }

            if (cb16.IsChecked == false)
            {
                num16 = 0;
                tax = 0.08m;
                subtotal = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10 + num11 + num12 + num13 + num14 + num15 + num16
                     + num17 + num18 + num19 + num20 + num21 + num22 + num23 + num24 + num25 + num26 + num27 + num28 + num29 + num30 + num31 + num32;
                taxrate = (subtotal * tax);
                total = subtotal + taxrate;
                subtotal_1.Text = subtotal.ToString("00.00");
                tax_1.Text = taxrate.ToString("00.00");
                total_1.Text = total.ToString("00.00");
            }
            else
            {
                num16 = 5.75m;

                tax = 0.08m;
                subtotal = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10 + num11 + num12 + num13 + num14 + num15 + num16
                     + num17 + num18 + num19 + num20 + num21 + num22 + num23 + num24 + num25 + num26 + num27 + num28 + num29 + num30 + num31 + num32;
                taxrate = (subtotal * tax);
                total = subtotal + taxrate;
                subtotal_1.Text = subtotal.ToString("00.00");
                tax_1.Text = taxrate.ToString("00.00");
                total_1.Text = total.ToString("00.00");
            }

            if (cb17.IsChecked == false)
            {
                num17 = 0;
                tax = 0.08m;
                subtotal = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10 + num11 + num12 + num13 + num14 + num15 + num16
                    + num17 + num18 + num19 + num20 + num21 + num22 + num23 + num24 + num25 + num26 + num27 + num28 + num29 + num30 + num31 + num32;
                taxrate = (subtotal * tax);
                total = subtotal + taxrate;
                subtotal_1.Text = subtotal.ToString("00.00");
                tax_1.Text = taxrate.ToString("00.00");
                total_1.Text = total.ToString("00.00");
            }
            else
            {
                num17 = 17.50m;

                tax = 0.08m;
                subtotal = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10 + num11 + num12 + num13 + num14 + num15 + num16
                   + num17 + num18 + num19 + num20 + num21 + num22 + num23 + num24 + num25 + num26 + num27 + num28 + num29 + num30 + num31 + num32;
                taxrate = (subtotal * tax);
                total = subtotal + taxrate;
                subtotal_1.Text = subtotal.ToString("00.00");
                tax_1.Text = taxrate.ToString("00.00");
                total_1.Text = total.ToString("00.00");
            }


            if (cb18.IsChecked == false)
            {
                num18 = 0;

                tax = 0.08m;
                subtotal = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10 + num11 + num12 + num13 + num14 + num15 + num16
                      + num17 + num18 + num19 + num20 + num21 + num22 + num23 + num24 + num25 + num26 + num27 + num28 + num29 + num30 + num31 + num32;
                taxrate = (subtotal * tax);
                total = subtotal + taxrate;
                subtotal_1.Text = subtotal.ToString("00.00");
                tax_1.Text = taxrate.ToString("00.00");
                total_1.Text = total.ToString("00.00");
            }
            else
            {
                num18 = 20.29m;
                tax = 0.08m;
                subtotal = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10 + num11 + num12 + num13 + num14 + num15 + num16
                      + num17 + num18 + num19 + num20 + num21 + num22 + num23 + num24 + num25 + num26 + num27 + num28 + num29 + num30 + num31 + num32;
                taxrate = (subtotal * tax);
                total = subtotal + taxrate;
                subtotal_1.Text = subtotal.ToString("00.00");
                tax_1.Text = taxrate.ToString("00.00");
                total_1.Text = total.ToString("00.00");
            }


            if (cb19.IsChecked == false)
            {
                num19 = 0;

                tax = 0.08m;
                subtotal = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10 + num11 + num12 + num13 + num14 + num15 + num16
                     + num17 + num18 + num19 + num20 + num21 + num22 + num23 + num24 + num25 + num26 + num27 + num28 + num29 + num30 + num31 + num32;
                taxrate = (subtotal * tax);
                total = subtotal + taxrate;
                subtotal_1.Text = subtotal.ToString("00.00");
                tax_1.Text = taxrate.ToString("00.00");
                total_1.Text = total.ToString("00.00");
            }
            else
            {
                num19 = 35.00m;

                tax = 0.08m;
                subtotal = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10 + num11 + num12 + num13 + num14 + num15 + num16
                    + num17 + num18 + num19 + num20 + num21 + num22 + num23 + num24 + num25 + num26 + num27 + num28 + num29 + num30 + num31 + num32;
                taxrate = (subtotal * tax);
                total = subtotal + taxrate;
                subtotal_1.Text = subtotal.ToString("00.00");
                tax_1.Text = taxrate.ToString("00.00");
                total_1.Text = total.ToString("00.00");
            }

            if (cb20.IsChecked == false)
            {
                num20 = 0;
                tax = 0.08m;
                subtotal = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10 + num11 + num12 + num13 + num14 + num15 + num16
                       + num17 + num18 + num19 + num20 + num21 + num22 + num23 + num24 + num25 + num26 + num27 + num28 + num29 + num30 + num31 + num32;
                taxrate = (subtotal * tax);
                total = subtotal + taxrate;
                subtotal_1.Text = subtotal.ToString("00.00");
                tax_1.Text = taxrate.ToString("00.00");
                total_1.Text = total.ToString("00.00");
            }
            else
            {
                num20 = 15.60m;

                tax = 0.08m;
                subtotal = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10 + num11 + num12 + num13 + num14 + num15 + num16
                       + num17 + num18 + num19 + num20 + num21 + num22 + num23 + num24 + num25 + num26 + num27 + num28 + num29 + num30 + num31 + num32;
                taxrate = (subtotal * tax);
                total = subtotal + taxrate;
                subtotal_1.Text = subtotal.ToString("00.00");
                tax_1.Text = taxrate.ToString("00.00");
                total_1.Text = total.ToString("00.00");
            }

            if (cb21.IsChecked == false)
            {
                num21 = 0;

                tax = 0.08m;
                subtotal = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10 + num11 + num12 + num13 + num14 + num15 + num16
                    + num17 + num18 + num19 + num20 + num21 + num22 + num23 + num24 + num25 + num26 + num27 + num28 + num29 + num30 + num31 + num32;
                taxrate = (subtotal * tax);
                total = subtotal + taxrate;
                subtotal_1.Text = subtotal.ToString("00.00");
                tax_1.Text = taxrate.ToString("00.00");
                total_1.Text = total.ToString("00.00");

            }
            else
            {
                num21 = 21.29m;

                tax = 0.08m;
                subtotal = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10 + num11 + num12 + num13 + num14 + num15 + num16
                    + num17 + num18 + num19 + num20 + num21 + num22 + num23 + num24 + num25 + num26 + num27 + num28 + num29 + num30 + num31 + num32;
                taxrate = (subtotal * tax);
                total = subtotal + taxrate;
                subtotal_1.Text = subtotal.ToString("00.00");
                tax_1.Text = taxrate.ToString("00.00");
                total_1.Text = total.ToString("00.00");

            }

            if (cb22.IsChecked == false)
            {
                num22 = 0;

                tax = 0.08m;
                subtotal = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10 + num11 + num12 + num13 + num14 + num15 + num16
                   + num17 + num18 + num19 + num20 + num21 + num22 + num23 + num24 + num25 + num26 + num27 + num28 + num29 + num30 + num31 + num32;
                taxrate = (subtotal * tax);
                total = subtotal + taxrate;
                subtotal_1.Text = subtotal.ToString("00.00");
                tax_1.Text = taxrate.ToString("00.00");
                total_1.Text = total.ToString("00.00");

            }
            else
            {
                num22 = 18.85m;

                tax = 0.08m;
                subtotal = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10 + num11 + num12 + num13 + num14 + num15 + num16
                    + num17 + num18 + num19 + num20 + num21 + num22 + num23 + num24 + num25 + num26 + num27 + num28 + num29 + num30 + num31 + num32;
                taxrate = (subtotal * tax);
                total = subtotal + taxrate;
                subtotal_1.Text = subtotal.ToString("00.00");
                tax_1.Text = taxrate.ToString("00.00");
                total_1.Text = total.ToString("00.00");

            }


            if (cb23.IsChecked == false)
            {
                num23 = 0;
                tax = 0.08m;
                subtotal = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10 + num11 + num12 + num13 + num14 + num15 + num16
                    + num17 + num18 + num19 + num20 + num21 + num22 + num23 + num24 + num25 + num26 + num27 + num28 + num29 + num30 + num31 + num32;
                taxrate = (subtotal * tax);
                total = subtotal + taxrate;
                subtotal_1.Text = subtotal.ToString("00.00");
                tax_1.Text = taxrate.ToString("00.00");
                total_1.Text = total.ToString("00.00");
            }
            else
            {
                num23 = 15.60m;

                tax = 0.08m;
                subtotal = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10 + num11 + num12 + num13 + num14 + num15 + num16
                    + num17 + num18 + num19 + num20 + num21 + num22 + num23 + num24 + num25 + num26 + num27 + num28 + num29 + num30 + num31 + num32;
                taxrate = (subtotal * tax);
                total = subtotal + taxrate;
                subtotal_1.Text = subtotal.ToString("00.00");
                tax_1.Text = taxrate.ToString("00.00");
                total_1.Text = total.ToString("00.00");
            }


            if (cb24.IsChecked == false)
            {
                num24 = 0;

                tax = 0.08m;
                subtotal = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10 + num11 + num12 + num13 + num14 + num15 + num16
                    + num17 + num18 + num19 + num20 + num21 + num22 + num23 + num24 + num25 + num26 + num27 + num28 + num29 + num30 + num31 + num32;
                taxrate = (subtotal * tax);
                total = subtotal + taxrate;
                subtotal_1.Text = subtotal.ToString("00.00");
                tax_1.Text = taxrate.ToString("00.00");
                total_1.Text = total.ToString("00.00");
            }
            else
            {
                num24 = 28.00m;

                tax = 0.08m;
                subtotal = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10 + num11 + num12 + num13 + num14 + num15 + num16
                       + num17 + num18 + num19 + num20 + num21 + num22 + num23 + num24 + num25 + num26 + num27 + num28 + num29 + num30 + num31 + num32;
                taxrate = (subtotal * tax);
                total = subtotal + taxrate;
                subtotal_1.Text = subtotal.ToString("00.00");
                tax_1.Text = taxrate.ToString("00.00");
                total_1.Text = total.ToString("00.00");
            }

            if (cb25.IsChecked == false)
            {
                num25 = 0;

                tax = 0.08m;
                subtotal = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10 + num11 + num12 + num13 + num14 + num15 + num16
                       + num17 + num18 + num19 + num20 + num21 + num22 + num23 + num24 + num25 + num26 + num27 + num28 + num29 + num30 + num31 + num32;
                taxrate = (subtotal * tax);
                total = subtotal + taxrate;
                subtotal_1.Text = subtotal.ToString("00.00");
                tax_1.Text = taxrate.ToString("00.00");
                total_1.Text = total.ToString("00.00");

            }
            else
            {
                num25 = 5.65m;

                tax = 0.08m;
                subtotal = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10 + num11 + num12 + num13 + num14 + num15 + num16
                       + num17 + num18 + num19 + num20 + num21 + num22 + num23 + num24 + num25 + num26 + num27 + num28 + num29 + num30 + num31 + num32;
                taxrate = (subtotal * tax);
                total = subtotal + taxrate;
                subtotal_1.Text = subtotal.ToString("00.00");
                tax_1.Text = taxrate.ToString("00.00");
                total_1.Text = total.ToString("00.00");

            }

            if (cb26.IsChecked == false)
            {
                num26 = 0;

                tax = 0.08m;
                subtotal = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10 + num11 + num12 + num13 + num14 + num15 + num16
                         + num17 + num18 + num19 + num20 + num21 + num22 + num23 + num24 + num25 + num26 + num27 + num28 + num29 + num30 + num31 + num32;
                taxrate = (subtotal * tax);
                total = subtotal + taxrate;
                subtotal_1.Text = subtotal.ToString("00.00");
                tax_1.Text = taxrate.ToString("00.00");
                total_1.Text = total.ToString("00.00");

            }
            else
            {
                num26 = 4.50m;

                tax = 0.08m;
                subtotal = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10 + num11 + num12 + num13 + num14 + num15 + num16
                    + num17 + num18 + num19 + num20 + num21 + num22 + num23 + num24 + num25 + num26 + num27 + num28 + num29 + num30 + num31 + num32;
                taxrate = (subtotal * tax);
                total = subtotal + taxrate;
                subtotal_1.Text = subtotal.ToString("00.00");
                tax_1.Text = taxrate.ToString("00.00");
                total_1.Text = total.ToString("00.00");

            }


            if (cb27.IsChecked == false)
            {
                num27 = 0;
                tax = 0.08m;
                subtotal = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10 + num11 + num12 + num13 + num14 + num15 + num16
                     + num17 + num18 + num19 + num20 + num21 + num22 + num23 + num24 + num25 + num26 + num27 + num28 + num29 + num30 + num31 + num32;
                taxrate = (subtotal * tax);
                total = subtotal + taxrate;
                subtotal_1.Text = subtotal.ToString("00.00");
                tax_1.Text = taxrate.ToString("00.00");
                total_1.Text = total.ToString("00.00");
            }
            else
            {
                num27 = 6.00m;

                tax = 0.08m;
                subtotal = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10 + num11 + num12 + num13 + num14 + num15 + num16
                    + num17 + num18 + num19 + num20 + num21 + num22 + num23 + num24 + num25 + num26 + num27 + num28 + num29 + num30 + num31 + num32;
                taxrate = (subtotal * tax);
                total = subtotal + taxrate;
                subtotal_1.Text = subtotal.ToString("00.00");
                tax_1.Text = taxrate.ToString("00.00");
                total_1.Text = total.ToString("00.00");
            }


            if (cb28.IsChecked == false)
            {
                num28 = 0;

                tax = 0.08m;
                subtotal = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10 + num11 + num12 + num13 + num14 + num15 + num16
                    + num17 + num18 + num19 + num20 + num21 + num22 + num23 + num24 + num25 + num26 + num27 + num28 + num29 + num30 + num31 + num32;
                taxrate = (subtotal * tax);
                total = subtotal + taxrate;
                subtotal_1.Text = subtotal.ToString("00.00");
                tax_1.Text = taxrate.ToString("00.00");
                total_1.Text = total.ToString("00.00");
            }
            else
            {
                num28 = 3.75m;

                tax = 0.08m;
                subtotal = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10 + num11 + num12 + num13 + num14 + num15 + num16
                    + num17 + num18 + num19 + num20 + num21 + num22 + num23 + num24 + num25 + num26 + num27 + num28 + num29 + num30 + num31 + num32;
                taxrate = (subtotal * tax);
                total = subtotal + taxrate;
                subtotal_1.Text = subtotal.ToString("00.00");
                tax_1.Text = taxrate.ToString("00.00");
                total_1.Text = total.ToString("00.00");
            }

            if (cb29.IsChecked == false)
            {
                num29 = 0;

                tax = 0.08m;
                subtotal = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10 + num11 + num12 + num13 + num14 + num15 + num16
                    + num17 + num18 + num19 + num20 + num21 + num22 + num23 + num24 + num25 + num26 + num27 + num28 + num29 + num30 + num31 + num32;
                taxrate = (subtotal * tax);
                total = subtotal + taxrate;
                subtotal_1.Text = subtotal.ToString("00.00");
                tax_1.Text = taxrate.ToString("00.00");
                total_1.Text = total.ToString("00.00");

            }
            else
            {
                num29 = 100.00m;

                tax = 0.08m;
                subtotal = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10 + num11 + num12 + num13 + num14 + num15 + num16
                   + num17 + num18 + num19 + num20 + num21 + num22 + num23 + num24 + num25 + num26 + num27 + num28 + num29 + num30 + num31 + num32;
                taxrate = (subtotal * tax);
                total = subtotal + taxrate;
                subtotal_1.Text = subtotal.ToString("00.00");
                tax_1.Text = taxrate.ToString("00.00");
                total_1.Text = total.ToString("00.00");

            }

            if (cb30.IsChecked == false)
            {
                num30 = 0;

                tax = 0.08m;
                subtotal = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10 + num11 + num12 + num13 + num14 + num15 + num16
                    + num17 + num18 + num19 + num20 + num21 + num22 + num23 + num24 + num25 + num26 + num27 + num28 + num29 + num30 + num31 + num32;
                taxrate = (subtotal * tax);
                total = subtotal + taxrate;
                subtotal_1.Text = subtotal.ToString("00.00");
                tax_1.Text = taxrate.ToString("00.00");
                total_1.Text = total.ToString("00.00");

            }
            else
            {
                num30 = 153.20m;

                tax = 0.08m;
                subtotal = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10 + num11 + num12 + num13 + num14 + num15 + num16
                   + num17 + num18 + num19 + num20 + num21 + num22 + num23 + num24 + num25 + num26 + num27 + num28 + num29 + num30 + num31 + num32;
                taxrate = (subtotal * tax);
                total = subtotal + taxrate;
                subtotal_1.Text = subtotal.ToString("00.00");
                tax_1.Text = taxrate.ToString("00.00");
                total_1.Text = total.ToString("00.00");

            }


            if (cb31.IsChecked == false)
            {
                num31 = 0;
                tax = 0.08m;
                subtotal = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10 + num11 + num12 + num13 + num14 + num15 + num16
                    + num17 + num18 + num19 + num20 + num21 + num22 + num23 + num24 + num25 + num26 + num27 + num28 + num29 + num30 + num31 + num32;
                taxrate = (subtotal * tax);
                total = subtotal + taxrate;
                subtotal_1.Text = subtotal.ToString("00.00");
                tax_1.Text = taxrate.ToString("00.00");
                total_1.Text = total.ToString("00.00");
            }
            else
            {
                num31 = 122.50m;

                tax = 0.08m;
                subtotal = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10 + num11 + num12 + num13 + num14 + num15 + num16
                    + num17 + num18 + num19 + num20 + num21 + num22 + num23 + num24 + num25 + num26 + num27 + num28 + num29 + num30 + num31 + num32;
                taxrate = (subtotal * tax);
                total = subtotal + taxrate;
                subtotal_1.Text = subtotal.ToString("00.00");
                tax_1.Text = taxrate.ToString("00.00");
                total_1.Text = total.ToString("00.00");
            }


            if (cb32.IsChecked == false)
            {
                num32 = 0;

                tax = 0.08m;
                subtotal = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10 + num11 + num12 + num13 + num14 + num15 + num16
                     + num17 + num18 + num19 + num20 + num21 + num22 + num23 + num24 + num25 + num26 + num27 + num28 + num29 + num30 + num31 + num32;
                taxrate = (subtotal * tax);
                total = subtotal + taxrate;
                subtotal_1.Text = subtotal.ToString("00.00");
                tax_1.Text = taxrate.ToString("00.00");
                total_1.Text = total.ToString("00.00");
            }
            else
            {
                num32 = 91.75m;

                tax = 0.08m;
                subtotal = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10 + num11 + num12 + num13 + num14 + num15 + num16
                   + num17 + num18 + num19 + num20 + num21 + num22 + num23 + num24 + num25 + num26 + num27 + num28 + num29 + num30 + num31 + num32;
                taxrate = (subtotal * tax);
                total = subtotal + taxrate;
                subtotal_1.Text = subtotal.ToString("00.00");
                tax_1.Text = taxrate.ToString("00.00");
                total_1.Text = total.ToString("00.00");
            }


        }







        private void total_TextChanged(object sender, TextChangedEventArgs e)
        {

        }





        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void txt_TextChanged_2(object sender, TextChangedEventArgs e)
        {


        }

        private void txt6_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void c6_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ListBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ListBox_SelectionChanged_2(object sender, SelectionChangedEventArgs e)
        {

        }

        private void subtotal_1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            saveHistory();


            Uri pageURI = new Uri("page4.xaml", UriKind.Relative);
            this.NavigationService.Navigate(pageURI);

        }

        private void saveHistory()
        {
            WebClient webClient = new WebClient();
            var result = JsonValue.Parse(webClient.DownloadString("http://hot100number1s.com/wpf/test.php?method=SaveHistory&u=" + App.Current.Properties["user"] + "&d=" + DateTime.Now.ToLongDateString() + "&i=" + selected2)).ToString();

        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            Uri pageURI = new Uri("page5.xaml", UriKind.Relative);
            this.NavigationService.Navigate(pageURI);

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Uri pageURI = new Uri("History.xaml", UriKind.Relative);
            this.NavigationService.Navigate(pageURI);
        }

      
    }
}
