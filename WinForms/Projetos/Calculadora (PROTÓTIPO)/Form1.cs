using static System.Drawing.Color;
namespace Calculadora;

public partial class Form1 : Form
{
    public string DisplayText = "0";
    public Label Display;
    

    public Form1()
    {
        InitializeComponent();
        
        this.Size = new System.Drawing.Size(300, 465);
        this.FormBorderStyle = FormBorderStyle.FixedSingle;
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.BackColor = Color.FromArgb(255, 255, 255);
        this.Text = "Calculator";
        this.StartPosition = FormStartPosition.Manual;
        int screenWidth = Screen.PrimaryScreen.Bounds.Width;
        int x = screenWidth - this.Width;
        int y = 0;
        this.Location = new Point(x + 9, y);
        InitializeCustomComponents();


    }
    
    
    public void InitializeCustomComponents()
    {
        
        System.Drawing.Color GridColor = System.Drawing.Color.FromArgb(0, 0, 30);
        System.Drawing.Color ButtonColor1 = System.Drawing.Color.FromArgb(10,55,120);
        System.Drawing.Color ButtonColor2 = System.Drawing.Color.FromArgb(55,155,175);
        System.Drawing.Color ButtonColor3 = System.Drawing.Color.FromArgb(145,0,255);

        for (int i = Controls.Count - 1; i >= 0; i--)
        {
            if (Controls[i] is Label || Controls[i] is Button)
                Controls.RemoveAt(i);
        }


        Display = new Label()
        {
            Text = DisplayText,
            Font = new Font("Arial", 16, FontStyle.Regular),
            TextAlign = System.Drawing.ContentAlignment.MiddleRight,
            ForeColor = System.Drawing.Color.FromArgb(0, 0, 0),
            Width = 284,
            Height = 50,
            BackColor = Color.FromArgb(50, 95, 255)
        };
        Controls.Add(Display);

        InicializeGrid(GridColor);


        Button ReverseButton = new Button()
        {
            Font = new Font("Arial", 10, FontStyle.Regular),
            TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
            Text = "+/-",
            BackColor = ButtonColor3,
            Width = 69,
            Height = 73,
            Top = 52,
            Left = 2,
            FlatStyle = FlatStyle.Flat
        };
        ReverseButton.FlatAppearance.BorderSize = 0;
        Controls.Add(ReverseButton);

        Button DivisionButton = new Button()
        {
            Font = new Font("Arial", 14, FontStyle.Regular),
            TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
            Text = "÷",
            BackColor = ButtonColor2,
            Width = 69,
            Height = 73,
            Top = 52,
            Left = 73,
            FlatStyle = FlatStyle.Flat
        };
        DivisionButton.FlatAppearance.BorderSize = 0;
        Controls.Add(DivisionButton);

        Button MultButton = new Button()
        {
            Font = new Font("Arial", 9, FontStyle.Regular),
            TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
            Text = "X",
            BackColor = ButtonColor2,
            Width = 69,
            Height = 73,
            Top = 52,
            Left = 144,
            FlatStyle = FlatStyle.Flat,
        };
        MultButton.FlatAppearance.BorderSize = 0;
        Controls.Add(MultButton);

        Button SubButton = new Button()
        {
            Font = new Font("Arial", 14, FontStyle.Regular),
            TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
            Text = "-",
            BackColor = ButtonColor2,
            Width = 69,
            Height = 73,
            Top = 52,
            Left = 215,
            FlatStyle = FlatStyle.Flat,
        };
        SubButton.FlatAppearance.BorderSize = 0;
        Controls.Add(SubButton);

        Button Button7 = new Button()
        {
            Font = new Font("Arial", 12, FontStyle.Regular),
            TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
            Text = "7",
            BackColor = ButtonColor1,
            Width = 69,
            Height = 73,
            Top = 127,
            Left = 2,
            FlatStyle = FlatStyle.Flat,
        };
        Button7.FlatAppearance.BorderSize = 0;
        Controls.Add(Button7);

        Button Button8 = new Button()
        {
            Font = new Font("Arial", 12, FontStyle.Regular),
            TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
            Text = "8",
            BackColor = ButtonColor1,
            Width = 69,
            Height = 73,
            Top = 127,
            Left = 73,
            FlatStyle = FlatStyle.Flat,
        };
        Button8.FlatAppearance.BorderSize = 0;
        Controls.Add(Button8);

        Button Button9 = new Button()
        {
            Font = new Font("Arial", 12, FontStyle.Regular),
            TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
            Text = "9",
            BackColor = ButtonColor1,
            Width = 69,
            Height = 73,
            Top = 127,
            Left = 144,
            FlatStyle = FlatStyle.Flat,
        };
        Button9.FlatAppearance.BorderSize = 0;
        Controls.Add(Button9);

        Button SumButton = new Button()
        {
            Font = new Font("Arial", 12, FontStyle.Regular),
            TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
            Text = "+",
            BackColor = ButtonColor2,
            Width = 69,
            Height = 148,
            Top = 127,
            Left = 215,
            FlatStyle = FlatStyle.Flat,
        };
        SumButton.FlatAppearance.BorderSize = 0;
        Controls.Add(SumButton);

        Button Button4 = new Button()
        {
            Font = new Font("Arial", 12, FontStyle.Regular),
            TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
            Text = "4",
            BackColor = ButtonColor1,
            Width = 69,
            Height = 73,
            Top = 202,
            Left = 2,
            FlatStyle = FlatStyle.Flat,
        };
        Button4.FlatAppearance.BorderSize = 0;
        Controls.Add(Button4);

        Button Button5 = new Button()
        {
            Font = new Font("Arial", 12, FontStyle.Regular),
            TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
            Text = "5",
            BackColor = ButtonColor1,
            Width = 69,
            Height = 73,
            Top = 202,
            Left = 73,
            FlatStyle = FlatStyle.Flat,
        };
        Button5.FlatAppearance.BorderSize = 0;
        Controls.Add(Button5);

        Button Button6 = new Button()
        {
            Font = new Font("Arial", 12, FontStyle.Regular),
            TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
            Text = "6",
            BackColor = ButtonColor1,
            Width = 69,
            Height = 73,
            Top = 202,
            Left = 144,
            FlatStyle = FlatStyle.Flat,
        };
        Button6.FlatAppearance.BorderSize = 0;
        Controls.Add(Button6);

        Button Button1 = new Button()
        {
            Font = new Font("Arial", 12, FontStyle.Regular),
            TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
            Text = "1",
            BackColor = ButtonColor1,
            Width = 69,
            Height = 73,
            Top = 277,
            Left = 2,
            FlatStyle = FlatStyle.Flat,
        };
        Button1.FlatAppearance.BorderSize = 0;
        Controls.Add(Button1);
        

        Button Button2 = new Button()
        {
            Font = new Font("Arial", 12, FontStyle.Regular),
            TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
            Text = "2",
            BackColor = ButtonColor1,
            Width = 69,
            Height = 73,
            Top = 277,
            Left = 73,
            FlatStyle = FlatStyle.Flat,
        };
        Button2.FlatAppearance.BorderSize = 0;
        Controls.Add(Button2);

        Button Button3 = new Button()
        {
            Font = new Font("Arial", 12, FontStyle.Regular),
            TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
            Text = "3",
            BackColor = ButtonColor1,
            Width = 69,
            Height = 73,
            Top = 277,
            Left = 144,
            FlatStyle = FlatStyle.Flat,
        };
        Button3.FlatAppearance.BorderSize = 0;
        Controls.Add(Button3);

        Button AllClearButton = new Button()
        {
            Font = new Font("Arial", 10, FontStyle.Regular),
            TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
            Text = "AC",
            BackColor = ButtonColor3,
            Width = 69,
            Height = 73,
            Top = 277,
            Left = 215,
            FlatStyle = FlatStyle.Flat,
        };
        AllClearButton.FlatAppearance.BorderSize = 0;
        Controls.Add(AllClearButton);

        Button Button0 = new Button()
        {
            Font = new Font("Arial", 12, FontStyle.Regular),
            TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
            Text = "0",
            BackColor = ButtonColor1,
            Width = 140,
            Height = 73,
            Top = 352,
            Left = 2,
            FlatStyle = FlatStyle.Flat,
        };
        Button0.FlatAppearance.BorderSize = 0;
        Controls.Add(Button0);

        Button CommaButton = new Button()
        {
            Font = new Font("Arial", 20, FontStyle.Regular),
            TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
            Text = ",",
            BackColor = System.Drawing.Color.FromArgb(55,55,120),
            Width = 69,
            Height = 73,
            Top = 352,
            Left = 144,
            FlatStyle = FlatStyle.Flat,
        };
        CommaButton.FlatAppearance.BorderSize = 0;
        Controls.Add(CommaButton);

        Button OkButton = new Button()
        {
            Font = new Font("Arial", 12, FontStyle.Regular),
            TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
            Text = "=",
            BackColor = System.Drawing.Color.FromArgb(55,35,255),
            Width = 69,
            Height = 73,
            Top = 352,
            Left = 215,
            FlatStyle = FlatStyle.Flat,
        };
        OkButton.FlatAppearance.BorderSize = 0;
        Controls.Add(OkButton);

        Button1.Click += (s, e) => Click(1);
        Button2.Click += (s, e) => Click(2);
        Button3.Click += (s, e) => Click(3);
        Button4.Click += (s, e) => Click(4);
        Button5.Click += (s, e) => Click(5);
        Button6.Click += (s, e) => Click(6);
        Button7.Click += (s, e) => Click(7);
        Button8.Click += (s, e) => Click(8);
        Button9.Click += (s, e) => Click(9);
        Button0.Click += (s, e) => Click(0);
        AllClearButton.Click += (s, e) => Click(10);
        SumButton.Click += (s, e) => Click(11);
        SubButton.Click += (s, e) => Click(12);
        MultButton.Click += (s, e) => Click(13);
        DivisionButton.Click += (s, e) => Click(14);
        OkButton.Click += (s, e) => Click(15);
        ReverseButton.Click += (s, e) => Click(16);
    }

    public void Click(int v)
    {
        if (v >= 1 && v < 10 && DisplayText.Length == 1 && DisplayText[0] == '0')
        {
            DisplayText = "";
        }
        switch (v)
        {
            case 1:
                DisplayText += "1";
                Display.Text = DisplayText;
                break;
            
            case 2:
                DisplayText += "2";
                Display.Text = DisplayText;
                break;
            case 3:
                DisplayText += "3";
                Display.Text = DisplayText;
                break;
            case 4:
                DisplayText += "4";
                Display.Text = DisplayText;
                break;
            case 5:
                DisplayText += "5";
                Display.Text = DisplayText;
                break;
            case 6:
                DisplayText += "6";
                Display.Text = DisplayText;
                break;
            case 7:
                DisplayText += "7";
                Display.Text = DisplayText;
                break;
            case 8:
                DisplayText += "8";
                Display.Text = DisplayText;
                break;
            case 9:
                DisplayText += "9";
                Display.Text = DisplayText;
                break;
            case 0:
                DisplayText += "0";
                Display.Text = DisplayText;
                break;
            case 10:
                DisplayText = "0";
                Display.Text = DisplayText;
                break;
            case 11:
                
                if(DisplayText[DisplayText.Length - 1] != ' ')
                {
                   DisplayText += " + ";
                    Display.Text = DisplayText;
                }
                break;
            case 12:
                
                if(DisplayText[DisplayText.Length - 1] != ' ')
                {
                   DisplayText += " - ";
                    Display.Text = DisplayText;
                }
                break;
            case 13:
                
                if(DisplayText[DisplayText.Length - 1] != ' ')
                {
                   DisplayText += " x ";
                    Display.Text = DisplayText;
                }
                break;
            case 14:
                
                if(DisplayText[DisplayText.Length - 1] != ' ')
                {
                   DisplayText += " ÷ ";
                    Display.Text = DisplayText;
                }
                break;
            case 15:
                
                if(DisplayText[DisplayText.Length - 1] != ' ')
                {
                   DisplayText = DisplayText.Remove(DisplayText.Length - 3);
                   Calcular(DisplayText);
                }
                break;
            case 16:
                int FirstPosition = 0;
                int LastPosition = 0;
                if(DisplayText[DisplayText.Length - 1] != ' ')
                {
                    LastPosition = DisplayText.Length - 1;
                }
                for(int i = DisplayText.Length - 1; i > 0; i--)
                {
                    if(DisplayText[i] == ' ')
                    {
                        FirstPosition = i + 1;
                        i = -9999;
                        break;
                    }

    
                }
                if(DisplayText[DisplayText.Length - 1] != ' ')
                {
                    
                    string DisplayTextAtt = DisplayText.Substring(0, DisplayText.Length); //33
                    int x = Convert.ToInt32(DisplayText.Substring(FirstPosition, LastPosition + 1 - FirstPosition)) * -1; //-33
                    string DisplayTextAtt2 = DisplayTextAtt.Substring(0, FirstPosition);  
                    DisplayText = DisplayTextAtt2 + x.ToString();
                    Display.Text = DisplayText;

                }

                break;
            
        }
    }
    public void InicializeGrid(System.Drawing.Color GridColor)
    {
        Label GradeVertical1 = new Label()
        {
            Width = 2,
            Height = 375,
            BackColor = GridColor,
            Top = 50
        };
        Controls.Add(GradeVertical1);
        Label GradeVertical2 = new Label()
        {
            Width = 2,
            Height = 300,
            BackColor = GridColor,
            Top = 50,
            Left = 71
        };
        Controls.Add(GradeVertical2);
        Label GradeVertical3 = new Label()
        {
            Width = 2,
            Height = 375,
            BackColor = GridColor,
            Top = 50,
            Left = 142
        };
        Controls.Add(GradeVertical3);
        Label GradeVertical4 = new Label()
        {
            Width = 2,
            Height = 375,
            BackColor = GridColor,
            Top = 50,
            Left = 213
        };
        Controls.Add(GradeVertical4);
        Label GradeVertical5 = new Label()
        {
            Width = 2,
            Height = 375,
            BackColor = GridColor,
            Top = 50,
            Left = 283
        };
        Controls.Add(GradeVertical5);

        Label GradeHorizontal1 = new Label()
        {
            Top = 50,
            Height = 2,
            Width = 284,
            BackColor = GridColor
        };
        Controls.Add(GradeHorizontal1);
        Label GradeHorizontal2 = new Label()
        {
            Top = 125,
            Height = 2,
            Width = 284,
            BackColor = GridColor
        };
        Controls.Add(GradeHorizontal2);
        Label GradeHorizontal3 = new Label()
        {
            Top = 200,
            Height = 2,
            Width = 213,
            BackColor = GridColor
        };
        Controls.Add(GradeHorizontal3);
        Label GradeHorizontal4 = new Label()
        {
            Top = 275,
            Height = 2,
            Width = 284,
            BackColor = GridColor
        };
        Controls.Add(GradeHorizontal4);
        Label GradeHorizontal5 = new Label()
        {
            Top = 350,
            Height = 2,
            Width = 284,
            BackColor = GridColor
        };
        Controls.Add(GradeHorizontal5);
        Label GradeHorizontal6 = new Label()
        {
            Top = 425,
            Height = 2,
            Width = 284,
            BackColor = GridColor
        };
        Controls.Add(GradeHorizontal6);
        Label GradeHorizontal7 = new Label()
        {
            Top = 424,
            Height = 2,
            Width = 284,
            BackColor = GridColor
        };
        Controls.Add(GradeHorizontal7);
    }

    public void Calcular(string Formula)
    {
        
    }
}