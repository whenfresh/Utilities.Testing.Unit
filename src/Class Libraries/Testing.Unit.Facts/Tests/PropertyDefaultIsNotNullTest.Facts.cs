﻿namespace Testing.Unit.Facts.Tests
{
    using Testing.Unit.Facts.Types;
    using WhenFresh.Rackspace;
    using WhenFresh.Rackspace.Tests;
    using Xunit;

    public sealed class PropertyDefaultIsNotNullTestFacts
    {
        [Fact]
        public void ctor_PropertyInfo_object()
        {
            Assert.NotNull(new PropertyDefaultIsNotNullTest(typeof(PropertiedClass1).GetProperty("AutoString")));
        }

        [Fact]
        public void is_PropertyTest()
        {
            Assert.IsAssignableFrom<PropertyTestBase>(new PropertyDefaultIsNotNullTest(typeof(PropertiedClass1).GetProperty("AutoString")));
        }

        [Fact]
        public void op_Check_whenFalse()
        {
            Assert.Throws<UnitTestException>(() => new PropertyDefaultIsNotNullTest(typeof(PropertiedClass1).GetProperty("AutoString")).Check());
        }

        [Fact]
        public void op_Check_whenTrue()
        {
            Assert.True(new PropertyDefaultIsNotNullTest(typeof(PropertiedClass1).GetProperty("AutoBoolean")).Check());
        }
    }
}