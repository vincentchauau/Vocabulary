using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MultiChoice
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }
        // First called function
        private void fMain_Load(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles(@".", "*.xlsx", SearchOption.AllDirectories);
            cbDatabase.Items.Clear();
            cbDatabase.Items.AddRange(files);
            cbDatabase.SelectedIndex = 0;
            cbType.SelectedIndex = 0;
            cbRemember.SelectedIndex = 0;
            tmStart.Start();
        }
        private int type = 0;
        private int times = 0, maxtimes = 0;
        private int interval = 0, hinttimes = 0, maxhinttimes = 5;
        private int typingtimes = 0, readingquestiontimes = 5, readinganswertimes = 3;
        private int remembertimes = 0, maxremembertimes = 0;
        private int questiontimes = -1, maxquestiontimes = 0;
        private int leveltimes = 0, maxleveltimes = 0;
        private DataRow row, row1, row2;
        private string answer = "", question = "";
        private char[] hint = new char[] { };
        // Scramble the answer
        private string Scramble(string str)
        {
            char[] array = str.ToCharArray();
            Random rng = new Random();
            int n = array.Length;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                var value = array[k];
                array[k] = array[n];
                array[n] = value;
            }
            return new string(array);
        }
        // Skip all the remembered questions
        private bool SkipQuestion()
        {
            int count = 0;
            do
            {
                // tang chi so count kiem tra da nho het list chua
                ++count;
                if (count == maxquestiontimes)
                {
                    times = 0;
                    return false;
                }
                else { }
                // tang chi so questiontimes de nhay toi cau hoi ke tiep
                ++questiontimes;
                // nhay tu cau hoi cuoi toi cau hoi dau tien
                if (questiontimes == maxquestiontimes)
                {
                    questiontimes = (leveltimes - 1) * 100;
                }
                else { }
                // lay thong tin cau hoi
                row = _dataTable.Rows[questiontimes];
                remembertimes = int.Parse(row["score"].ToString());
            } while (remembertimes >= maxremembertimes);
            return true;
        }
        // Second called function: Show the question and choices
        private void tmStart_Tick(object sender, EventArgs e)
        {
            if (times == 0)
            {
                // skip the remembered questions
                if (SkipQuestion() == true)
                {
                    question = row[_questionColumn].ToString();
                    answer = row[_answerColumn].ToString();
                    typingtimes = answer.Length / 3;
                    maxtimes = typingtimes + readingquestiontimes + readinganswertimes;
                    interval = (int)Math.Ceiling((double) typingtimes / maxhinttimes);
                    hinttimes = 0;
                    hint = new string('#', answer.Length).ToCharArray();
                    rtbAnswer.Text = "";
                    ++times;
                    Text = string.Format("Time: {0}/{1}. Remember: {2}/{3}. Question: {4}/{5}. Level: {6}/{7}", times, maxtimes, remembertimes, maxremembertimes, questiontimes, maxquestiontimes, leveltimes, maxleveltimes);
                    switch (type)
                    {
                        case 0:// Multichoice
                            Random random = new Random();
                            int iFakeAnswer1 = random.Next(maxquestiontimes);
                            int iFakeAnswer2 = random.Next(maxquestiontimes);
                            row1 = _dataTable.Rows[iFakeAnswer1];
                            row2 = _dataTable.Rows[iFakeAnswer2];
                            int iAnswerPosition = random.Next(3);
                            switch (iAnswerPosition)
                            {
                                case 0:
                                    rtbQuestion.Text = string.Format("{0}\nA.{1}\nB.{2}\nC.{3}", question, answer, row1[_answerColumn], row2[_answerColumn]);
                                    break;
                                case 1:
                                    rtbQuestion.Text = string.Format("{0}\nA.{2}\nB.{3}\nC.{1}", question, answer, row1[_answerColumn], row2[_answerColumn]);
                                    break;
                                case 2:
                                    rtbQuestion.Text = string.Format("{0}\nA.{3}\nB.{1}\nC.{2}", question, answer, row1[_answerColumn], row2[_answerColumn]);
                                    break;
                            }
                            break;
                        case 1:// Hint
                            rtbQuestion.Text = string.Format("{0}\n{1}", question, new string(hint));
                            break;
                        case 2:// Scramble
                            rtbQuestion.Text = string.Format("{0}\n{1}", question, Scramble(answer));
                            break;
                        case 3:// Puzzle
                            break;
                    }
                }
                else { }
            }
            else if (times < readingquestiontimes)
            {
                ++times;
                Text = string.Format("Time: {0}/{1}. Remember: {2}/{3}. Question: {4}/{5}. Level: {6}/{7}", times, maxtimes, remembertimes, maxremembertimes, questiontimes, maxquestiontimes, leveltimes, maxleveltimes);
            }
            else if (times < readingquestiontimes + typingtimes)
            {
                ++times;
                Text = string.Format("Time: {0}/{1}. Remember: {2}/{3}. Question: {4}/{5}. Level: {6}/{7}", times, maxtimes, remembertimes, maxremembertimes, questiontimes, maxquestiontimes, leveltimes, maxleveltimes);
                if (type == 1)
                {
                    if (times % interval == 0)
                    {
                        hinttimes = times / interval;
                        for (int i = 0; i < hint.Length; ++i)
                        {
                            if (i % 5 == hinttimes)
                            {
                                hint[i] = answer[i];
                            }
                            else { }
                        }
                        rtbQuestion.Text += "\n" + new string(hint);
                        rtbQuestion.SelectionStart = 0;
                        rtbQuestion.SelectionLength = rtbQuestion.TextLength;
                        rtbQuestion.SelectionFont = new Font("Times New Roman", 24, FontStyle.Bold);
                    }
                    else { }
                }
                else { }
            }
            else if (times == readingquestiontimes + typingtimes)
            {
                ++times;
                Text = string.Format("Time: {0}/{1}. Remember: {2}/{3}. Question: {4}/{5}. Level: {6}/{7}", times, maxtimes, remembertimes, maxremembertimes, questiontimes, maxquestiontimes, leveltimes, maxleveltimes);
                rtbQuestion.Text += "\nThe answer is: " + answer;
                rtbQuestion.SelectionStart = 0;
                rtbQuestion.SelectionLength = rtbQuestion.TextLength;
                rtbQuestion.SelectionFont = new Font("Times New Roman", 24, FontStyle.Bold);
            }
            else if (times < readingquestiontimes + typingtimes + readinganswertimes)
            {
                ++times;
                Text = string.Format("Time: {0}/{1}. Remember: {2}/{3}. Question: {4}/{5}. Level: {6}/{7}", times, maxtimes, remembertimes, maxremembertimes, questiontimes, maxquestiontimes, leveltimes, maxleveltimes);
            }
            else
            {
                times = 0;
            }
        }
        // Answer the question
        private void rtbAnswer_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // if the answer is correct
                if (rtbAnswer.Text.Contains(answer))
                {
                    rtbQuestion.Text += "\nYour answer is correct: " + answer;
                    rtbQuestion.SelectionStart = 0;
                    rtbQuestion.SelectionLength = rtbQuestion.TextLength;
                    rtbQuestion.SelectionFont = new Font("Times New Roman", 24, FontStyle.Bold);
                    _dataTable.Rows[questiontimes]["score"] = (++remembertimes);
                    times = readingquestiontimes + typingtimes;
                }
                else if (rtbAnswer.Text.Contains("!skip"))
                {
                    times = 0;
                }
                else { }
                rtbAnswer.Text = "";
            }
            else { }
        }
        // Get all tables of a excel files
        private void Excel2DataTables(string path, ref List<DataTable> dataTables)
        {
            dataTables = new List<DataTable>();
            String constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
                            path +
                            ";Extended Properties='Excel 12.0 XML;HDR=YES;CharacterSet=65001;';";
            OleDbConnection con = new OleDbConnection(constr);
            con.Open();
            DataTable dt = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
            foreach (DataRow row in dt.Rows)
            {
                DataTable dataTable = new DataTable();
                string name = row["TABLE_NAME"].ToString();
                dataTable.TableName = name;
                OleDbCommand oconn = new OleDbCommand("Select * From [" + name + "]", con);
                OleDbDataAdapter sda = new OleDbDataAdapter(oconn);
                sda.Fill(dataTable);
                dataTables.Add(dataTable);
            }
        }
        private List<DataTable> _dataTables;
        // Get all the datables of questionanswers
        private void cbDatabase_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbSheet.Items.Clear();
            Excel2DataTables(cbDatabase.Text, ref _dataTables);
            for (int i = 0; i < _dataTables.Count; ++i)
            {
                cbSheet.Items.Add(_dataTables[i].TableName);
            }
            cbSheet.SelectedIndex = 1;
        }
        private DataTable _dataTable;
        // Get the table of questionanswers
        private void cbSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            _dataTable = _dataTables[cbSheet.SelectedIndex];
            cbQuestion.Items.Clear();
            cbAnswer.Items.Clear();
            for (int i = 0; i < _dataTable.Columns.Count; ++i)
            {
                cbQuestion.Items.Add(_dataTable.Columns[i].ColumnName);
                cbAnswer.Items.Add(_dataTable.Columns[i].ColumnName);
            }
            cbLevel.Items.Clear();
            for (int i = 0; i < _dataTable.Rows.Count / 100 + 1; ++i)
            {
                cbLevel.Items.Add(i + 1);
            }
            cbQuestion.SelectedIndex = 0;
            cbAnswer.SelectedIndex = 0;
            cbLevel.SelectedIndex = 0;
        }
        private string _questionColumn;
        // Change the question column
        private void cbQuestion_SelectedIndexChanged(object sender, EventArgs e)
        {
            _questionColumn = cbQuestion.Text;
        }
        private string _answerColumn;
        // Change the answer column
        private void cbAnswer_SelectedIndexChanged(object sender, EventArgs e)
        {
            _answerColumn = cbAnswer.Text;
        }
        // Change remember times
        private void cbRemember_SelectedIndexChanged(object sender, EventArgs e)
        {
            maxremembertimes = int.Parse(cbRemember.Text);
        }
        // Change levels times
        private void cbLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            leveltimes = int.Parse(cbLevel.Text);
            maxleveltimes = cbLevel.Items.Count;
            questiontimes = (leveltimes - 1) * 100 - 1;
            if (leveltimes == maxleveltimes)
            {
                maxquestiontimes = _dataTable.Rows.Count;
            }
            else
            {
                maxquestiontimes = leveltimes * 100;
            }
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            type = cbType.SelectedIndex;
        }
    }
}