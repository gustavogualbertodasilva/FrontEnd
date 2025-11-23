using static System.Drawing.Color;
namespace Calculadora;

public partial class Form1 : Form
{
    public System.Drawing.Color GridColor = System.Drawing.Color.FromArgb(0, 0, 50);
    private System.Windows.Forms.Timer refreshTimer;

    public Form1()
    {
        InitializeComponent();
        refreshTimer = new System.Windows.Forms.Timer();
        refreshTimer.Interval = 5000;
        refreshTimer.Tick += RefreshTimer_Tick;
        refreshTimer.Start();
        
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
        for (int i = Controls.Count - 1; i >= 0; i--)
        {
            if (Controls[i] is Label || Controls[i] is Button)
                Controls.RemoveAt(i);
        }


        Label Display = new Label()
        {
            Font = new Font("Arial", 16, FontStyle.Regular),
            TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
            ForeColor = System.Drawing.Color.FromArgb(0, 50, 255),
            Width = 284,
            Height = 50,
            BackColor = Color.FromArgb(0, 15, 55)
        };
        Controls.Add(Display);


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
            Width = 213,
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


        Button ReverseButton = new Button()
        {
            Font = new Font("Arial", 10, FontStyle.Regular),
            TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
            Text = "+/-",
            BackColor = System.Drawing.Color.FromArgb(55,55,120),
            Width = 69,
            Height = 73,
            Top = 52,
            Left = 2,
            FlatStyle = FlatStyle.Flat
        };
        Controls.Add(ReverseButton);
        ReverseButton.FlatAppearance.BorderSize = 0;
        ReverseButton.Font = new Font("Arial", 10, FontStyle.Regular);
    }

    private void RefreshTimer_Tick(object? sender, EventArgs e)
    {
        InitializeCustomComponents();
    }
}