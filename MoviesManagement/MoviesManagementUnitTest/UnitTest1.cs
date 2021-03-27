using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MoviesManagement.Controllers;
using MoviesManagement.DatabaseContext;
using MoviesManagement.Models;
using System.Reflection;
using NUnit.Framework;

namespace MoviesManagementUnitTest
{
    [TestFixture]
    public class UnitTest1
    {
        Assembly assembly;
        Type className, dbContextclassName, modelClassName;
        //[TestMethod]
        //public void TestMethod1()
        //{
        //}

        [SetUp]
        public void Setup()
        {
            assembly = Assembly.Load("MoviesManagement");
            className = assembly.GetType("MoviesManagement.Controllers.MoviesManagementController");
            modelClassName = assembly.GetType("MoviesManagement.Models.Movie");
            dbContextclassName = assembly.GetType("MoviesManagement.Data.MoviesDBContext");
        }

        [TestCase]
        public void PassportsController_WhenNoSuchClassFound_WarnsUser()
        {
            if (className == null)
                NUnit.Framework.Assert.Fail("No controller class with the name 'PassportsManagementController' is implemented OR Did you change the class name");
        }
    }
}
