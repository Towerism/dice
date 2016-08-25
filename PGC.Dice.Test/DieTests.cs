using FluentAssertions;
using NUnit.Framework;
using PGC.Dice.Interfaces;
using Rhino.Mocks;

namespace PGC.Dice.Test
{
    [TestFixture]
    public class DieTests
    {
        private IRandom _random;
        private Die _target;

        [SetUp]
        public void SetUp()
        {
            _random = MockRepository.GenerateStrictMock<IRandom>();
            _target = new Die(_random);
        }

        [TearDown]
        public void TearDown()
        {
            _random.VerifyAllExpectations();
        }


        [Test]
        public void RollShouldReturnARandomNumber()
        {
            _random.Expect(r => r.GetNumber()).Return(5);

            var result = _target.Roll();

            result.Should().Be(5);
        }
    }
}