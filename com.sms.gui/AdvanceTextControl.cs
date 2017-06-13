using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Globalization;

namespace com.sms.gui
{
    public partial class AdvanceTextControl : UserControl
    {
        public AdvanceTextControl()
        {
            InitializeComponent();
        }
        //Properties
        private bool isValidte;
        private string valuetext;
        private string inValidtext;
        private char requiredtext;
        private TextType typeVal = TextType.TEXT;
        private bool ignoreZero;
        private bool isRequire;
        private string requireMsg;

        public enum TextType
        {
            TEXT = 1,
            NUMBER = 2,
            NUMERIC = 3,
            CURRENCY = 4,
            EMAIL = 5,
            ADDRESS
        }
        //Events
        public event EventHandler TextUpdated;
        protected void OnTextUpdated(EventArgs e)
        {
            TextUpdated?.Invoke(this, e);
        }

        //Setter Getters        
        public TextType Type
        {
            get { return typeVal; }
            set
            {
                typeVal = value;
                SetState();
                if (box.Text == "" || box.Text == "0")
                {
                    ignoreZero = false;
                }
            }
        }
        public string AdvanceText
        {
            get { return valuetext; }
            set
            {
                valuetext = value;
                box.Text = valuetext;
            }
        }
        public string InvalidMessage
        {
            get { return inValidtext; }
            set { inValidtext = value; }
        }
        public char RequiredChar
        {
            get { return requiredtext; }
            set { requiredtext = value; }
        }
        public bool IsRequired
        {
            get { return isRequire; }
            set
            {
                isRequire = value;
            }
        }
        public int Length
        {
            get { return box.MaxLength; }
            set { box.MaxLength = value; }
        }
        private void SetState()
        {
            checkValues();
        }
        //Logics
        private void box_TextChanged(object sender, EventArgs e)
        {
            checkValues();
            AdvanceText = box.Text;
            OnTextUpdated(new EventArgs());
        }

        private void checkValues()
        {
            if (Type == TextType.CURRENCY)
            {
                int max = 20;
                if (box.Text.Length > 0 && box.Text.Length <= max)
                {
                    string allowedChars = "01234567890.";//remove all except number and .
                    box.Text = new string(box.Text.Where(c => allowedChars.Contains(c)).ToArray());
                    //check if dot is not at last and only one dot
                    if ((box.Text.IndexOf('.') != box.Text.Length - 1) && ((box.Text.Split('.').Length - 1) < 2))
                    {
                        decimal d = decimal.Parse(box.Text);
                        box.Text = decimal.Round(d, 2).ToString();
                        lbl.Text = requiMsg();
                    }
                    //check if dot is at last
                    else if ((box.Text.IndexOf('.') == box.Text.Length - 1))
                    {
                        lbl.Text = inValidtext;
                    }
                    //remove second dot form value
                    else if ((box.Text.Split('.').Length - 1) > 1)
                    {
                        box.Text = box.Text.Remove(box.Text.Length - 1);
                        lbl.Text = requiMsg();
                    }
                }
                else if (box.Text.Length > max)
                {
                    box.Text = box.Text.Remove(max);
                }
                else
                {
                    //set null value to zero
                    box.Text = "0";
                }
                box.SelectionStart = box.Text.Length;
            }
            else if (Type == TextType.NUMBER)
            {
                if (box.Text.Length > 0)
                {
                    string allowedChars = "01234567890";//remove all except number and .
                    box.Text = new string(box.Text.Where(c => allowedChars.Contains(c)).ToArray());
                    if (!ignoreZero)
                    {
                        if (box.Text == "00")
                        {
                            box.Text = "0";
                            ignoreZero = true;
                        }
                        else if (box.Text != "0" && box.Text.Length == 2 && box.Text[0] == '0')
                        {
                            box.Text = box.Text.Remove(0, 1);
                            ignoreZero = true;
                        }
                    }
                }
                else
                {
                    box.Text = "0";
                    ignoreZero = false;
                }
                lbl.Text = requiMsg();
                box.SelectionStart = box.Text.Length;
            }
            else if (Type == TextType.NUMERIC)
            {
                int max = 20;
                if (box.Text.Length > 0 && box.Text.Length <= max)
                {
                    string allowedChars = "01234567890.";//remove all except number and .
                    box.Text = new string(box.Text.Where(c => allowedChars.Contains(c)).ToArray());
                    //check if dot is at last and only one dot
                    if ((box.Text.IndexOf('.') != box.Text.Length - 1) && ((box.Text.Split('.').Length - 1) < 2))
                    {
                        //it will remove zero from head
                        if (box.Text.Length < 5)
                        {
                            box.Text = float.Parse(box.Text).ToString();
                        }
                        lbl.Text = requiMsg();
                    }
                    //check if dot is at last
                    else if ((box.Text.IndexOf('.') == box.Text.Length - 1))
                    {
                        lbl.Text = inValidtext;
                    }
                    //remove second dot form value
                    else if ((box.Text.Split('.').Length - 1) > 1)
                    {
                        box.Text = box.Text.Remove(box.Text.Length - 1);
                    }
                }
                else if (box.Text.Length > max)
                {
                    box.Text = box.Text.Remove(max);
                }
                else
                {
                    //set null value to zero
                    box.Text = "0";
                }
                box.SelectionStart = box.Text.Length;
            }
            else if (Type == TextType.EMAIL)
            {
                int loc = box.SelectionStart;
                if (box.Text.Length > 0)
                {
                    if (!Regex.IsMatch(box.Text, @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
       @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
       RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250)))
                    {
                        lbl.Text = inValidtext;
                    }
                    else
                    {
                        lbl.Text = requiMsg();
                    }
                }
                box.SelectionStart = loc;
            }
            else if (Type == TextType.TEXT)
            {
                lbl.Text = requiMsg();
            }
            else if (Type == TextType.ADDRESS)
            {
                int loc = box.SelectionStart;
                lbl.Text = requiMsg();
                TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
                box.Text = textInfo.ToTitleCase(box.Text);
                box.SelectionStart =loc;
            }
        }

        private string requiMsg()
        {
            if (isRequire)
            {
                return requiredtext + "";
            }
            else
            {
                return "";
            }
        }

        public bool isValid()
        {
            return isValidte;
        }

        private void AdvanceTextControl_Load(object sender, EventArgs e)
        {
            isValidte = false;
            box.Height = this.Height / 2;
            lbl.Height = this.Height / 2;
        }

        private void AdvanceTextControl_FontChanged(object sender, EventArgs e)
        {
            //box.Height = this.Height / 2;
            //box.Width = this.Width;
            //lbl.Height = this.Height / 2;
            //lbl.Width = this.Width;
        }
    }
}
