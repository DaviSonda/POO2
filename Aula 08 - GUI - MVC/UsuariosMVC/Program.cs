using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsuariosMVC
{
  internal static class Program
  {
    /// <summary>
    /// Ponto de entrada principal para o aplicativo.
    /// </summary>
    [STAThread]
    static void Main()
    {
      FrmUsuarios view = new FrmUsuarios();
      view.Visible = false;

      
      IList usuarios = new ArrayList();
      usuarios.Add(new Usuario("Martino", "Costa", "122", "Vendedor", Usuario.SexoPessoa.Masculino));
      usuarios.Add(new Usuario("Alex", "Machado", "123", "Consultor", Usuario.SexoPessoa.Masculino));
      usuarios.Add(new Usuario("Jorge", "Black", "124", "Desenvolvedor", Usuario.SexoPessoa.Masculino));
      usuarios.Add(new Usuario("Mariana", "Santos", "125", "Desenvolvedora", Usuario.SexoPessoa.Feminino));
      usuarios.Add(new Usuario("Paula", "Silva", "126", "Analista", Usuario.SexoPessoa.Feminino));
      usuarios.Add(new Usuario("Ana", "Buana", "127", "CIO", Usuario.SexoPessoa.Feminino));
      usuarios.Add(new Usuario("Rafael", "Mancko", "128", "Consultor", Usuario.SexoPessoa.Masculino));
      usuarios.Add(new Usuario("Sílvio", "Moraes", "129", "Analista", Usuario.SexoPessoa.Masculino));
      usuarios.Add(new Usuario("Carina", "Nodal", "130", "Diretora", Usuario.SexoPessoa.Feminino));

      UsuariosController controller = new UsuariosController(view, usuarios);
      controller.LoadView();
      view.ShowDialog();




     // Application.EnableVisualStyles();
     // Application.SetCompatibleTextRenderingDefault(false);
     // Application.Run(new FrmUsuarios());
    }
  }
}
