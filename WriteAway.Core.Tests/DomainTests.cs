using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using WriteAway.Core.Data;
using WriteAway.Core.Domain.Users;

namespace WriteAway.Core.Tests
{
    [TestClass]
    public class DomainTests
    {
        [TestMethod]
        public void IdShouldBeGuid()
        {
            User newUser = new User();
            
            Assert.IsInstanceOfType(newUser.Id, typeof(Guid));
        }


    }
}
