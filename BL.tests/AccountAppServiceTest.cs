using BL.AppServices;
using DAL;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.tests
{
    class AccountAppServiceTest
    {
        AccountAppService accountAppService = new AccountAppService();
        [Test]
        public void FindTest()
        {
            var result = accountAppService.Find("ss", "123456");

            Assert.That(result, Is.EqualTo(new ApplicationUserIDentity()));
        }
    }
}
