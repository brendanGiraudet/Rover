using System;
using Library.Enum;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Library.Tests
{
    [TestClass]
    public class Rover
    {
        public Class.Rover Robot { get; set; } = new Class.Rover();

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
            Assert.IsTrue(Robot.Position.Y == 9);
        }

        [TestMethod]
        public void Should_keep_x_and_decrease_y_when_faces_north_and_move_backward()
        {
            Robot.DirectionGaze = Direction.North;
            Robot.Move(Movement.Backward);
            Assert.IsTrue(Robot.Position.X == 2);
            Assert.IsTrue(Robot.Position.Y == 7);
        }

        [TestMethod]
        public void Should_faces_east_when_faces_north_and_turn_right()
        {
            Robot.DirectionGaze = Direction.North;
            Robot.Turn(Movement.Right);
            Assert.IsTrue(Robot.DirectionGaze == Direction.East);
        }
        [TestMethod]
        public void Should_faces_north_when_faces_west_and_turn_right()
        {
            Robot.DirectionGaze = Direction.West;
            Robot.Turn(Movement.Right);
            Assert.IsTrue(Robot.DirectionGaze == Direction.North);
        }
        [TestMethod]
        public void Should_faces_west_when_faces_north_and_turn_left()
        {
            Robot.DirectionGaze = Direction.North;
            Robot.Turn(Movement.Left);
            Assert.IsTrue(Robot.DirectionGaze == Direction.West);
        }
    }
}
