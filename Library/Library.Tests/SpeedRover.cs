using Library.Enum;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Library.Tests
{
    [TestClass]
    public class SpeedRover
    {
        public Class.SpeedRover Robot { get; set; } = new Class.SpeedRover();

        [TestInitialize]
        public void SetUp()
        {
            Robot.Position.X = 2;
            Robot.Position.Y = 8;
            Robot.DirectionGaze = Direction.East;
        }

        [TestMethod]
        public void Should_keep_x_and_raise_y_when_faces_north_and_move_forward()
        {
            Robot.DirectionGaze = Direction.North;
            Robot.Move(Movement.Forward);
            Assert.IsTrue(Robot.Position.X == 2);
            Assert.IsTrue(Robot.Position.Y == 10);
        }

        [TestMethod]
        public void Should_keep_x_and_decrease_y_when_faces_north_and_move_backward()
        {
            Robot.DirectionGaze = Direction.North;
            Robot.Move(Movement.Backward);
            Assert.IsTrue(Robot.Position.X == 2);
            Assert.IsTrue(Robot.Position.Y == 6);
        }
    }
}
