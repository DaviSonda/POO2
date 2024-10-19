namespace DaviSonegoA1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            FracaoView view = new FracaoView();
            view.Visible = false;

            CalculaFracao model = new CalculaFracao();
            FracaoController controller = new FracaoController(view, model);
            view.ShowDialog();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            // ApplicationConfiguration.Initialize();
            // Application.Run(new FracaoView());
        }
    }
}