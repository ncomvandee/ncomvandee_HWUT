using Microsoft.VisualStudio.TestTools.UnitTesting;
using HWUT.Models;
using System;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace UnitTests
{
    [TestClass]
    public class ProductModelTests
    {
        [TestMethod]
        public void ProductModel_Constructor_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ProductModel_Get_Date_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(DateTime.UtcNow.ToShortDateString(), result.Date.ToShortDateString());
        }
        [TestMethod]
        public void ProductModel_Get_AverageRating_Valid_Should_Pass()
        {
            // Arrange
            var data = new ProductModel();

            // Act
            var result = data.AverageRating();

            // Assert
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void ProductModel_Get_AverageRating_Invalid_Should_Return_0()
        {
            // Arrange
            var data = new ProductModel();
            data.Ratings = null;

            // Act
            var result = data.AverageRating();

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void ProductModel_Get_AverateRating_ElementInArray_IsZero_Should_Return_0()
        {
            // Arrange
            var data = new ProductModel();
            data.Ratings[0] = 0;

            // Act
            var result = data.AverageRating();

            // Assert
            Assert.AreEqual(0, result);

        }

        [TestMethod]
        public void ProductModel_Get_AverateRating_Rating_WithNoElement_Should_Return_0()
        {
            // Arrange
            var data = new ProductModel();
            data.Ratings = new int[0];
            

            // Act
            var result = data.AverageRating();

            // Assert
            Assert.AreEqual(0, result);

        }

        [TestMethod]
        public void ProductModel_Get_Default_Id_Should_Return_Null()
        {
            // Arrange
            var data = new ProductModel();

            // Act
            var result = data.Id;

            // Assert
            Assert.IsNull(result);

        }

        [TestMethod]
        public void ProductModel_Get_Id_Valid_Should_Pass()
        {
            // Arrange
            var data = new ProductModel();
            data.Id = "ncomvandee";

            // Act
            var result = data.Id;

            // Assert
            Assert.AreEqual("ncomvandee", result);
        }

        [TestMethod]
        public void ProductModel_Get_Maker_Default_Should_Return_Null()
        {
            // Arrange
            var data = new ProductModel();

            // Act
            var result = data.Maker;

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void ProductModel_Get_Maker_Valid_Should_Pass()
        {
            // Arrange
            var data = new ProductModel();
            data.Maker = "Ken Comvandee";

            // Act
            var result = data.Maker;

            // Assert
            Assert.AreEqual("Ken Comvandee", result);
        }

        [TestMethod]
        public void ProductModel_Get_Image_Default_Should_Return_Null()
        {
            // Arrange
            var data = new ProductModel();

            // Act
            var result = data.Image;

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void ProductModel_Get_Image_Valid_Should_Pass()
        {
            // Arrange
            var data = new ProductModel();
            data.Image = "Picture.png";

            // Act
            var result = data.Image;

            // Assert
            Assert.AreEqual("Picture.png", result);
        }

        [TestMethod]
        public void ProductModel_Get_Url_Default_Should_Retuen_Null()
        {
            // Arrange
            var data = new ProductModel();

            // Act
            var result = data.Url;

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void ProductModel_Get_Url_Valid_Should_Pass()
        {
            // Arrange
            var data = new ProductModel();
            data.Url = "CPSC5041.seattleu.edu";

            // Act
            var result = data.Url;

            // Assert
            Assert.AreEqual("CPSC5041.seattleu.edu", result);
        }

        [TestMethod]
        public void ProductModel_Get_Title_Default_Should_Return_Null()
        {
            // Arrange
            var data = new ProductModel();

            // Act
            var result = data.Title;

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void ProductModel_Get_Title_Valid_Should_Pass()
        {
            // Arrange
            var data = new ProductModel();
            data.Title = "MacBook Air 2014";

            // Act
            var result = data.Title;

            // Assert
            Assert.AreEqual("MacBook Air 2014", result);
        }

        [TestMethod]
        public void ProductModel_Get_Description_Default_Should_Return_Null()
        {
            // Arrange
            var data = new ProductModel();

            // Act
            var result = data.Description;

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void ProductModel_Get_Description_Valid_Should_Pass()
        {
            // Arrange
            var data = new ProductModel();
            var Des = "Good condition MacBook Air 2014. No Damage, no dent, no scratch. Owner used only";
            data.Description = Des;

            // Act
            var result = data.Description;

            // Assert
            Assert.AreEqual(Des, result);
        }

        [TestMethod]
        public void ProductModel_Get_Sequence_Default_Should_Return_Null()
        {
            // Arrange
            var data = new ProductModel();

            // Act
            var result = data.Sequence;

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void ProductModel_Get_Sequence_Valid_Should_Pass()
        {
            // Arrange
            var data = new ProductModel();
            var Seq = "Jump to the Privacy page to see site policy";
            data.Sequence = Seq;

            // Act
            var result = data.Sequence;

            // Assert
            Assert.AreEqual(Seq, result);
        }

        [TestMethod]
        public void ProductModel_Get_Email_Default_Should_Pass()
        {
            // Arrange
            var data = new ProductModel();

            // Act
            var result = data.Email;

            // Assert
            Assert.AreEqual("Unknown", result);
        }

        [TestMethod]
        public void ProductModel_Get_Logistic_Default_Should_Return_Empty()
        {
            // Arrange
            var data = new ProductModel();

            // Act
            var result = data.Logistics;

            // Assert
            Assert.AreEqual("", result);
        }

        [TestMethod]
        public void ProductModel_Get_ToString_Default_Should_Pass()
        {
            // Arrange
            var data = new ProductModel();

            // Act
            var result = data.ToString();

            // Assert
            Assert.AreEqual(data.ToString(), result);
        }
    }
}
