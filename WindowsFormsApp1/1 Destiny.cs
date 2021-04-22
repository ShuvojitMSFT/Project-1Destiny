using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Outlook = Microsoft.Office.Interop.Outlook;
using OneNote = Microsoft.Office.Interop.OneNote;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Net.Mail;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using Microsoft.Office.Interop.Outlook;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Runtime.InteropServices;
using Application = Microsoft.Office.Interop.OneNote.Application;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.Remoting.Messaging;
using Exception = System.Exception;
using System.Windows.Controls;
using System.Timers;
using System.Runtime.CompilerServices;
using System.Diagnostics;
using System.Drawing.Printing;
using System.IO;
using RtfPipe.Tokens;
using Word = Microsoft.Office.Interop.Word;
using Image = System.Drawing.Image;
using Powerpoint = Microsoft.Office.Interop.PowerPoint;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
namespace Project_1Destiny
{
    public partial class Form1 : Form
    {
        private delegate void SafeCallDelegate();
        string FormName1 = "";
        string FormName2 = "";
        
        string productChoice = "";
        private Stopwatch stopwatch;
         public Form1()
        {
            InitializeComponent();
            string root = @"C:\Temp";
            string subdir = @"C:\Temp\Destiny1";
            // If directory does not exist, create it. 
            if (!Directory.Exists(root))
            {
                Directory.CreateDirectory(root);
            }
            if (!Directory.Exists(subdir))
            {
                Directory.CreateDirectory(subdir);
            }
            this.Text = "Project 1Destiny";
            case_set=new HashSet<int>();
            tooltipinit();
           
            stopwatch = new Stopwatch();
            areatotime = new Dictionary<int, string>()
            {
                {201,"EST" },{202,"EST"},{203,"EST" },{204,"CST"},{205,"CST" },{206,"PST"},{207,"EST" },{208,"MST"},{209,"PST" },{210,"CST"},{212,"EST" },{213,"PST"} 
            };
            string dir = @"C:\temp\destiny1";
            var files = from file in Directory.EnumerateFiles(dir) select file;
            foreach(string file in files)
            {
                int st=file.LastIndexOf('\\');
                int end = file.LastIndexOf(".rtf");
                string s = file.Substring(st+1, end - st - 1);
                try
                {
                    int a = Int32.Parse(s);
                    case_set.Add(a);
                }
                catch
                {
                    continue;
                }
            }
            foreach (int c in case_set)
            {
                CaseListBox.Items.Add(c);
            }
            Debug.Write(System.Windows.Forms.Application.UserAppDataPath);
            //Soap_template.LoadFile(@"C:/temp/Soap.RTF");
            //this is just a comment 
        }
        

        private void Reset_Click(object sender, EventArgs e)
        {          
               
            CaseNumber.Clear();     
                
            toolStripStatusLabel1.Text = "Ready!";
           
        }

        private void SendToEscalation_Click(object sender, EventArgs e)
        {
            Outlook.Application oApp = new Outlook.Application();
            Outlook._MailItem oMailItem = (Outlook._MailItem)oApp.CreateItem(Outlook.OlItemType.olMailItem);
            oMailItem.To = "bhamv@microsoft.com; shraycha@microsoft.com";
            oMailItem.Subject = "Need Assistance on Case:" + CaseNumber.Text;
            //Copy richTextBox information to Clipboard
            Clipboard.Clear();
            SOAPNotes.SelectAll();
            SOAPNotes.Copy();
            //Set Body Format to HTML
            oMailItem.BodyFormat = Outlook.OlBodyFormat.olFormatHTML;
            //Converting RTF to HTML (Using NuGet RTFPipe).
            var html = RtfPipe.Rtf.ToHtml(Clipboard.GetText(TextDataFormat.Rtf));
            oMailItem.HTMLBody = html;
            // body, bcc etc...
           // oMailItem.Display(false);
            ((Outlook._MailItem)oMailItem).Send();
            toolStripStatusLabel1.Text = "Email Sent to Escalation Team!";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void Copy_Click(object sender, EventArgs e)
        {
            DataObject CopySOAPNotesContent = new DataObject();
            CopySOAPNotesContent.SetData(DataFormats.Rtf, SOAPNotes.Rtf);
            Clipboard.SetDataObject(CopySOAPNotesContent);
            toolStripStatusLabel1.Text = "Copied to Clipboard.";
        }

       private void CaseNumberLabel_Click(object sender, EventArgs e)
       {
       }

       
		private void SendToOneNote_Click_1(object sender, EventArgs e)
		{
            Outlook.Application oApp = new Outlook.Application();
            Outlook._MailItem oMailItem = (Outlook._MailItem)oApp.CreateItem(Outlook.OlItemType.olMailItem);
            oMailItem.To = "me@onenote.com";
      oMailItem.Subject = "[Case #:" + CaseNumber.Text+"]";
            //Copy richTextBox information to Clipboard
            Clipboard.Clear();
            SOAPNotes.SelectAll();
            SOAPNotes.Copy();
            //Set Body Format to RTF
            oMailItem.BodyFormat = Outlook.OlBodyFormat.olFormatHTML;
            //Converting RTF to HTML (Using NuGet RTFPipe).
            var html = RtfPipe.Rtf.ToHtml(Clipboard.GetText(TextDataFormat.Rtf));
            oMailItem.HTMLBody = html;
            // body, bcc etc...
            //oMailItem.Display(false);
            ((Outlook._MailItem)oMailItem).Send();
            toolStripStatusLabel1.Text = "Notes transferred to your assigned Notebook";
        }

		private void SOAPNotesContent_TextChanged(object sender, EventArgs e)
		{

		}

		private void AddtoCase_Click(object sender, EventArgs e)
		{
            
           /* Outlook.Application oApp = new Outlook.Application();
            Outlook._MailItem oMailItem = (Outlook._MailItem)oApp.CreateItem(Outlook.OlItemType.olMailItem);
            oMailItem.To = "msprm@microsoft.com";
            oMailItem.Subject = "[Case #:" + CaseNumber.Text + "]";
            Clipboard.Clear();
            SOAPNotes.SelectAll();
            SOAPNotes.Copy();
            //Set Body Format to RTF
            oMailItem.BodyFormat = Outlook.OlBodyFormat.olFormatHTML;
            //Converting RTF to HTML (Using NuGet RTFPipe).
            var html = RtfPipe.Rtf.ToHtml(Clipboard.GetText(TextDataFormat.Rtf));
            oMailItem.HTMLBody = html;
            // body, bcc etc...
            oMailItem.Display(false);
            ((Outlook._MailItem)oMailItem).Send();*/
        }

		private void FeedbackLink_Click(object sender, LinkLabelLinkClickedEventArgs e)
		{
            System.Diagnostics.Process.Start("https://forms.microsoft.com/Pages/ResponsePage.aspx?id=v4j5cvGGr0GRqy180BHbR8eeHjSeM2dHnaQimfx6UWlUN0ZUNlI4MEdEM0wzNkZMNlZUMFk0SFpZRi4u");

        }

        private void SOAPNotes_TextChanged(object sender, EventArgs e)
        {
                 
            

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void tooltipinit()
        {
            toolStripStatusLabel1.Text = "Ready!";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
        private void Home_Soap_TextChanged(object sender, EventArgs e)
        {

        }

        private void CaseNumber_TextChanged(object sender, EventArgs e)
        {
           //this.Text = "Project 1Desttiny";
           
            FormName2=CaseNumber.Text;
            try
            {
                if (case_set.Contains(Convert.ToInt32(FormName2)))
                {
                    SOAPNotes.LoadFile("c:\\Temp\\Destiny1\\" + CaseNumber.Text + ".rtf");
                    whatis.LoadFile("c:\\Temp\\Destiny1\\" + CaseNumber.Text + "_whatis.rtf");
                    whatisnt.LoadFile("c:\\Temp\\Destiny1\\" + CaseNumber.Text + "_whatisnt.rtf");
                    whenis.LoadFile("c:\\Temp\\Destiny1\\" + CaseNumber.Text + "_whenis.rtf");
                    whenisnt.LoadFile("c:\\Temp\\Destiny1\\" + CaseNumber.Text + "_whenisnt.rtf");
                    whereis.LoadFile("c:\\Temp\\Destiny1\\" + CaseNumber.Text + "_whereis.rtf");
                    whereisnt.LoadFile("c:\\Temp\\Destiny1\\" + CaseNumber.Text + "_whereisnt.rtf");
                    extentis.LoadFile("c:\\Temp\\Destiny1\\" + CaseNumber.Text + "_extentis.rtf");
                    extentisnt.LoadFile("c:\\Temp\\Destiny1\\" + CaseNumber.Text + "_extentisnt.rtf");
                }
                this.Text = "Project 1Desttiny" + " : " + FormName2;
            }
            catch(Exception ex)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("quickassist.exe");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

           /* System.Windows.Forms.PrintDialog dlg = new System.Windows.Forms.PrintDialog();
             dlg.ShowDialog();
             PrintDocument pdoc = new PrintDocument();
             dlg.Document = pdoc;
             StringReader reader = new StringReader(SOAPNotes.Text);
            // reader += new PrintPageEventHandler(DocumentToPrint_PrintPage);
             reader.();
             pdoc.Print();*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                toolStripStatusLabel1.Text = "Ready!";
                SOAPNotes.Text = Soap_template.Text;
                whatis.Text = "";
            whatisnt.Text = "";
            whereis.Text = "";
            whereisnt.Text = "";
            extentis.Text = "";
            extentisnt.Text = "";
            whenis.Text = "";
            whenisnt.Text = "";

        }

        private void scrappad_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            

                var estTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
                DateTime estTime = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, estTimeZone);
               // var etime = estTime.ToShortTimeString();
            string s = estTime.ToString("hh:mm tt");
            EST.Text = "EST: "+s;



            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
                var MaTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Mountain Standard Time");
                DateTime MaTime = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, MaTimeZone);
            string s = MaTime.ToString("hh:mm tt");
            MST.Text = "MST: "+ s;
            

        }

        private void CST_Click(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            var caTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Central Standard Time");
            DateTime CaTime = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, caTimeZone);
            string s = CaTime.ToString("hh:mm tt");
            CST.Text = "CST: " + s;
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            var paTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");
            DateTime paTime = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, paTimeZone);
            string s = paTime.ToString("hh:mm tt");
            PST.Text = "PST: " + s;
        }

        private void CET_Click(object sender, EventArgs e)
        {

        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            var cesTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Central Europe Standard Time");
            DateTime cesTime = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, cesTimeZone);
            string s = cesTime.ToString("hh:mm tt");
            CET.Text = "CEST:" + s;
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            var gmtTimeZone = TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time");
            DateTime gmtTime = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, gmtTimeZone);
            string s = gmtTime.ToString("hh:mm tt");
            GMT.Text = "GMT: " + s;
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            var arabTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Arab Standard Time");
            DateTime arabTime = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, arabTimeZone);
            var aratime = arabTime.ToShortTimeString();
            string s = arabTime.ToString("hh:mm tt");
            ARAB.Text = "ARAB:" + s;
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataObject CopySOAPNotesContent = new DataObject();
            CopySOAPNotesContent.SetData(DataFormats.Rtf, SOAPNotes.Rtf);
            Clipboard.SetDataObject(CopySOAPNotesContent);
            toolStripStatusLabel1.Text = "Copied to Clipboard.";
        }

       

       
        private void wrdbtn_Click(object sender, EventArgs e)
        {
            DataObject CopySOAPNotesContent = new DataObject();
            CopySOAPNotesContent.SetData(DataFormats.Rtf, SOAPNotes.Rtf);
            Clipboard.SetDataObject(CopySOAPNotesContent);
            Word.Application ap = new Word.Application();
            ap.Visible = true;
            Word.Document doc = ap.Documents.Add();
            doc.Range(0, 0).Paste();
            ap.DocumentBeforeClose += new Word.ApplicationEvents4_DocumentBeforeCloseEventHandler(
                (Word.Document Doc, ref bool Cancel) => {

                    doc.Range(0, doc.Paragraphs[doc.Paragraphs.Count - 1].Range.End).Copy();


                    UpdateSoapNote();
                    Cancel = true;
                    doc.Close(false);
                    ap.Quit();
                }
            );

        }

        public void UpdateSoapNote()
        {
            //Check if invoke requied if so return - as i will be recalled in correct thread
            if (SOAPNotes.InvokeRequired)
            {
                var d = new SafeCallDelegate(UpdateSoapNote);
                SOAPNotes.Invoke(d);
            }
            else
            {
                SOAPNotes.Clear();
                SOAPNotes.Paste();
            }
        }

        private void tbrFont_Click(object sender, EventArgs e)
        {
            SelectFontToolStripMenuItem_Click(this, e);
        }


        private void SelectFontToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (!(SOAPNotes.SelectionFont == null))
                {
                    fontDialog1.Font = SOAPNotes.SelectionFont;
                }
                else
                {
                    fontDialog1.Font = null;
                }
                fontDialog1.ShowApply = true;
                if (fontDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    SOAPNotes.SelectionFont = fontDialog1.Font;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void tspColor_Click(object sender, EventArgs e)
        {
            FontColorToolStripMenuItem_Click(this, new EventArgs());
        }

        private void FontColorToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            try
            {
                ColorDialog1.Color =SOAPNotes.ForeColor;
                if (ColorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    SOAPNotes.SelectionColor = ColorDialog1.Color;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void tbrLeft_Click(object sender, System.EventArgs e)
        {
            SOAPNotes.SelectionAlignment = HorizontalAlignment.Left;
        }


        private void tbrCenter_Click(object sender, System.EventArgs e)
        {
            SOAPNotes.SelectionAlignment = HorizontalAlignment.Center;
        }


        private void tbrRight_Click(object sender, System.EventArgs e)
        {
            SOAPNotes.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void tbrBold_Click(object sender, System.EventArgs e)
        {
            BoldToolStripMenuItem_Click(this, e);
        }

        private void BoldToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (!(SOAPNotes.SelectionFont == null))
                {
                    System.Drawing.Font currentFont = SOAPNotes.SelectionFont;
                    System.Drawing.FontStyle newFontStyle;

                    newFontStyle = SOAPNotes.SelectionFont.Style ^ FontStyle.Bold;

                    SOAPNotes.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void tbrItalic_Click(object sender, System.EventArgs e)
        {
            ItalicToolStripMenuItem_Click(this, e);
        }

        private void ItalicToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (!(SOAPNotes.SelectionFont == null))
                {
                    System.Drawing.Font currentFont = SOAPNotes.SelectionFont;
                    System.Drawing.FontStyle newFontStyle;

                    newFontStyle = SOAPNotes.SelectionFont.Style ^ FontStyle.Italic;

                    SOAPNotes.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }
        private void tbrUnderline_Click(object sender, System.EventArgs e)
        {
            UnderlineToolStripMenuItem_Click(this, e);
        }

        private void UnderlineToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (!(SOAPNotes.SelectionFont == null))
                {
                    System.Drawing.Font currentFont = SOAPNotes.SelectionFont;
                    System.Drawing.FontStyle newFontStyle;

                    newFontStyle = SOAPNotes.SelectionFont.Style ^ FontStyle.Underline;

                    SOAPNotes.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void insrtImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog1.Title = "RTE - Insert Image File";
            OpenFileDialog1.DefaultExt = "rtf";
            OpenFileDialog1.Filter = "Bitmap Files|*.bmp|JPEG Files|*.jpg|GIF Files|*.gif|PNG files|*.png";
            OpenFileDialog1.FilterIndex = 1;
            OpenFileDialog1.ShowDialog();

            if (OpenFileDialog1.FileName == "")
            {
                return;
            }

            try
            {
                string strImagePath = OpenFileDialog1.FileName;
                Image img;
                img = Image.FromFile(strImagePath);
                Clipboard.SetDataObject(img);
                DataFormats.Format df;
                df = DataFormats.GetFormat(DataFormats.Bitmap);
                if (this.SOAPNotes.CanPaste(df))
                {
                    this.SOAPNotes.Paste(df);
                }
            }
            catch
            {
                MessageBox.Show("Unable to insert image format selected.", "RTE - Paste", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {if (!SOAPNotes.SelectionBullet)
                {
                    SOAPNotes.BulletIndent = 10;
                    SOAPNotes.SelectionBullet = true;
                    
                }
            else
                {
                    SOAPNotes.BulletIndent = 0;
                    SOAPNotes.SelectionBullet = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {   

        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void screencapturebtn_Click(object sender, EventArgs e)
        {
            Powerpoint.Application ap = new Powerpoint.Application();
            Powerpoint.Presentation pres=ap.Presentations.Add();
            Microsoft.Office.Interop.PowerPoint.CustomLayout customLayout = pres.SlideMaster.CustomLayouts[Microsoft.Office.Interop.PowerPoint.PpSlideLayout.ppLayoutText];
            Powerpoint.Slide s=pres.Slides.AddSlide(1, customLayout);
            ap.CommandBars.ExecuteMso("ObjectScreenRecordingAutoPlay");
            
           

        }
        private Dictionary<int, string> areatotime;
        private void button3_Click(object sender, EventArgs e)
        {
            int code = Convert.ToInt32(tbArea.Text);
            if (areatotime.ContainsKey(code))
            {
                lbtimezone.Text = areatotime[code];
            }
            else
                lbtimezone.Text = "NA";

        }
        private bool timeron = false;

        private void timer8_Tick(object sender, EventArgs e)
        {
            lbstopwatch.Text = string.Format("{0:hh\\:mm\\:ss\\:fff}",stopwatch.Elapsed);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(!timeron)
            {
                timeron = true;
                button5.Text = "Stop";
                stopwatch.Start();
            }
            else
            {
                timeron = false;
                button5.Text = "Start";
                stopwatch.Stop();
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button5.Text = "Start";
            stopwatch.Reset();
        }
        private HashSet<int> case_set;
        private void button7_Click(object sender, EventArgs e)
        {
            case_set.Add(Convert.ToInt32(CaseNumber.Text));
            CaseListBox.Items.Add(Convert.ToInt32(CaseNumber.Text));
            SOAPNotes.SaveFile("c:\\Temp\\Destiny1\\" + CaseNumber.Text + ".rtf");
            whatis.SaveFile("c:\\Temp\\Destiny1\\" + CaseNumber.Text + "_whatis.rtf");
            whatisnt.SaveFile("c:\\Temp\\Destiny1\\" + CaseNumber.Text + "_whatisnt.rtf");
            whenis.SaveFile("c:\\Temp\\Destiny1\\" + CaseNumber.Text + "_whenis.rtf");
            whenisnt.SaveFile("c:\\Temp\\Destiny1\\" + CaseNumber.Text + "_whenisnt.rtf");
            whereis.SaveFile("c:\\Temp\\Destiny1\\" + CaseNumber.Text + "_whereis.rtf");
            whereisnt.SaveFile("c:\\Temp\\Destiny1\\" + CaseNumber.Text + "_whereisnt.rtf");
            extentis.SaveFile("c:\\Temp\\Destiny1\\" + CaseNumber.Text + "_extentis.rtf");
            extentisnt.SaveFile("c:\\Temp\\Destiny1\\" + CaseNumber.Text + "_extentisnt.rtf");
            toolStrip1.Text = CaseNumber.Text + " Saved";


        }

        private void commitbtn_Click(object sender, EventArgs e)
        {
            int casenum = Int32.Parse(CaseNumber.Text);
            if (case_set.Contains(casenum))
            case_set.Remove(casenum);
            CaseListBox.Items.Remove(casenum);
            if (File.Exists(@"C:\temp\DEstiny1\" + casenum + ".rtf"))
            {
                File.Delete(@"C:\temp\DEstiny1\" + casenum + ".rtf");
                File.Delete("c:\\Temp\\Destiny1\\" + CaseNumber.Text + "_whatis.rtf");
                File.Delete("c:\\Temp\\Destiny1\\" + CaseNumber.Text + "_whatisnt.rtf");
                File.Delete("c:\\Temp\\Destiny1\\" + CaseNumber.Text + "_whenis.rtf");
                File.Delete("c:\\Temp\\Destiny1\\" + CaseNumber.Text + "_whenisnt.rtf");
                File.Delete("c:\\Temp\\Destiny1\\" + CaseNumber.Text + "_whereis.rtf");
                File.Delete("c:\\Temp\\Destiny1\\" + CaseNumber.Text + "_whereisnt.rtf");
                File.Delete("c:\\Temp\\Destiny1\\" + CaseNumber.Text + "_extentis.rtf");
                File.Delete("c:\\Temp\\Destiny1\\" + CaseNumber.Text + "_extentisnt.rtf");
            }
            CaseNumber.Text = " ";
            SOAPNotes.Text = Soap_template.Text;

        }

        private void CaseListBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CaseNumber.Text = CaseListBox.Text;
            

        }

        private void OffGen_Soap_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void meetingbtn_Click(object sender, EventArgs e)
        {
            Outlook.Application oApp = new Outlook.Application();

            
            
            Outlook.AppointmentItem appointmentItem = (Outlook.AppointmentItem)oApp.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olAppointmentItem);

            appointmentItem.Subject = "[Case:" + CaseNumber.Text + "]";

            appointmentItem.Display();

            
        }

        private void meetingbtn_Click_1(object sender, EventArgs e)
        {
            
        }
    }

}


    
