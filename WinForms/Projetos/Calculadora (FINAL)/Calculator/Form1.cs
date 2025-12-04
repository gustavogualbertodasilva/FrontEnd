using static System.Drawing.Color;
using System.Data;
using System.Globalization;

namespace Calculator;

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

    private void InitializeCustomComponents()
    {
        System.Drawing.Color GridColor = System.Drawing.Color.FromArgb(0, 0, 30);
        System.Drawing.Color ButtonColor1 = System.Drawing.Color.FromArgb(10, 55, 120);
        System.Drawing.Color ButtonColor2 = System.Drawing.Color.FromArgb(55, 155, 175);
        System.Drawing.Color ButtonColor3 = System.Drawing.Color.FromArgb(145, 0, 255);

        for(int i = Controls.Count - 1; i>= 0; i--)
        {
            if(Controls[i] is Label || Controls[i] is Button)
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
}
