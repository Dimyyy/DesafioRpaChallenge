using Dominio.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dominio.Interfaces;
using System.Threading.Tasks;

namespace Executor
{
    public class Runner : IRunner
    {
        private readonly IWebDriverServices _webDriverServices;
        private readonly IRpaChallengeService _rpaChallengeService;

        public Runner(
            
             IWebDriverServices webDriverService,
             IRpaChallengeService rpaChallengeService
             )
        {
          
            _webDriverServices = webDriverService;
            _rpaChallengeService = rpaChallengeService;
        }
        public void Run()
        {
            try
            {
                _rpaChallengeService.AbrirSite();
                _rpaChallengeService.GoToUrl();
                _rpaChallengeService.ClicarStart();
                _rpaChallengeService.DownloadExcel();
               
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
