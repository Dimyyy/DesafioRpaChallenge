using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interfaces
{
    public interface IRpaChallengeService
    {
        /// <summary>
        /// Instanciar o navegador
        /// </summary>
        void AbrirSite();

        /// <summary>
        /// Navegar para uma url
        /// </summary>
        void GoToUrl();

        void DownloadExcel();

        void ClicarStart();

        void PreencherFormulario(string firstName, string lastName, string companyName, string roleCompany, string address, string email, string phoneNumber);

        void ClicarSubmit();

        string ResultadoDesafio();
    }
}
