namespace Blue_Pilot.Domain.Tests;

using Blue.Pilot.Domain.Catalog;
using Blue_Pilot.Domain;

[TestClass]
public class RatingTests
{
    [TestMethod]

    [ExpectedException(typeof(ArgumentException))]
    public void Cannot_Create_Rating_With_Invalid_Stars() {
        
        // Arrange
        var rating = new Rating (0, "Mike", "Great fit!");
    }

    public void Can_Create_New_Rating() {

        // Arrange
        var rating = new Rating (1, "Mike", "Great fit!");

        // Act (empty)

        // Assert
        Assert.AreEqual (1, rating.Stars);
        Assert.AreEqual ("Mike", rating.UserName);
        Assert.AreEqual ("Great fit!", rating.Review);
}


}