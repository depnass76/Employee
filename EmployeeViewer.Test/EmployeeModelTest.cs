using Employee.Layered;
using NUnit.Framework;
using System.Reflection;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace EmployeeViewer.Test
{
    public class EmployeeModelTest
    {

        [Test]
        public  void People_OnFetchData_IsPopulated()
        {
            //Arrange
            EmployeeViewModel viewModel = new EmployeeViewModel();

            //Act
            viewModel.FetchEmployeeData();

            //Assert
            Assert.IsNotNull(viewModel.People.Equals(2));
            Assert.AreEqual(2, viewModel.People.Equals(2));
        }
    }
}
