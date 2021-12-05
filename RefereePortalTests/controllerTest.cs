using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RefereePortal.Controllers;
using RefereePortal.Data;
using RefereePortal.Models;
using System.Collections.Generic;

namespace RefereePortalTests
{
    [TestClass]
    public class controllerTest
    {
        private ApplicationDbContext mockDb; 
        GamesController control;
        List<Game> games = new List<Game>();

        [TestMethod]
        //Arrange
        //Act
        //Assert
        public void IndexLoad()
        {
            var control = new GamesController();
            var views = (ViewResult)control.Index();

            Assert.AreEqual("Controller", views.ViewName["test"]);
        }
        [TestMethod]
        public void CreateGame()
        {
              
            var game = new Game { };
            control.ModelState.AddModelError("put a descriptive key name here", "add an appropriate key value here");
            var res = control.Create(game, null);
            var views = (ViewResult)game.Res;
            
            Assert.AreEqual("Create", views.ViewName);
        }
    }
}
