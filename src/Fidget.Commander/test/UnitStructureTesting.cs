﻿using System;
using Xunit;

namespace Fidget.Commander
{
    /// <summary>
    /// Tests of the unit structure.
    /// </summary>
    
    public class UnitStructureTesting
    {
        /// <summary>
        /// Tests of the non-generic CompareTo methods.
        /// </summary>
        
        public class CompareTo_NonGeneric
        {
            /// <summary>
            /// Instance under test.
            /// </summary>
            
            IComparable Instance = new Unit();

            /// <summary>
            /// Reports as the same position as itself.
            /// </summary>
            
            [Fact]
            public void ReturnsZero_WhenComparedToSelf()
            {
                var actual = Instance.CompareTo( Instance );
                Assert.Equal( 0, actual );
            }
            
            /// <summary>
            /// Reports as the same position when compared to the default instance.
            /// </summary>

            [Fact]
            public void ReturnsZero_WhenComparedToDefault()
            {
                var actual = Instance.CompareTo( Unit.Default );
                Assert.Equal( 0, actual );
            }
        }

        /// <summary>
        /// Tests of the generic CompareTo method.
        /// </summary>
        
        public class CompareTo_Generic
        {
            /// <summary>
            /// Instance under test.
            /// </summary>

            IComparable<Unit> Instance = new Unit();

            /// <summary>
            /// Reports as the same position as itself.
            /// </summary>

            [Fact]
            public void ReturnsZero_WhenComparedToSelf()
            {
                var actual = Instance.CompareTo( (Unit)Instance );
                Assert.Equal( 0, actual );
            }

            /// <summary>
            /// Reports as the same position when compared to the default instance.
            /// </summary>

            [Fact]
            public void ReturnsZero_WhenComparedToDefault()
            {
                var actual = Instance.CompareTo( Unit.Default );
                Assert.Equal( 0, actual );
            }
        }

        /// <summary>
        /// Tests of the non-generic Equals method.
        /// </summary>
        
        public class Equals_NonGeneric
        {
            /// <summary>
            /// Instance under test.
            /// </summary>

            object Instance = new Unit();
            
            /// <summary>
            /// Reports as equal when compared to itself.
            /// </summary>

            [Fact]
            public void ReturnsTrue_WhenComparedToSelf()
            {
                var actual = Instance.Equals( Instance );
                Assert.True( actual );
            }

            /// <summary>
            /// Reports as equal when compared to the default instance.
            /// </summary>

            [Fact]
            public void ReturnsTrue_WhenComparedToDefault()
            {
                var actual = Instance.Equals( Unit.Default );
                Assert.True( actual );
            }

            /// <summary>
            /// Reports as not equal when compared to an object of another type.
            /// </summary>

            [Fact]
            public void ReturnsFalse_WhenComparedToOtherType()
            {
                var actual = Instance.Equals( this );
                Assert.False( actual );
            }
        }

        /// <summary>
        /// Tests of the generic Equals operator.
        /// </summary>
        
        public class Equals_Generic
        {
            /// <summary>
            /// Instance under test.
            /// </summary>
            
            IEquatable<Unit> Instance = new Unit();

            /// <summary>
            /// Reports equal when compared to itself.
            /// </summary>

            [Fact]
            public void ReturnsTrue_WhenComparedToSelf()
            {
                var actual = Instance.Equals( (Unit)Instance );
                Assert.True( actual );
            }

            /// <summary>
            /// Reports equal when compared to the default instance.
            /// </summary>

            [Fact]
            public void ReturnsTrue_WhenComparedToDefault()
            {
                var actual = Instance.Equals( Unit.Default );
                Assert.True( actual );
            }
        }

        /// <summary>
        /// Tests of the GetHashCode method.
        /// </summary>

        public class GetHashCode_Override
        {
            /// <summary>
            /// Should always return zero.
            /// </summary>

            [Fact]
            public void ReturnsZero()
            {
                var unit = new Unit();
                var actual = unit.GetHashCode();

                Assert.Equal( 0, actual );
            }
        }

        /// <summary>
        /// Tests of the equality operator.
        /// </summary>
        
        public class EqualityOperator
        {
            /// <summary>
            /// Instance under test.
            /// </summary>
            
            Unit Instance = new Unit();

            /// <summary>
            /// Reports equal when compared to itself.
            /// </summary>

            [Fact]
            public void ReturnsTrue_WhenComparedToSelf()
            {
                #pragma warning disable CS1718
                Assert.True( Instance == Instance );
                #pragma warning restore CS1718

                // xunit should also recognize as equal
                Assert.Equal( Instance, Instance );
            }

            /// <summary>
            /// When compared to the default instance, true should be returned.
            /// </summary>

            [Fact]
            public void ReturnsTrue_WhenComparedToDefault()
            {
                Assert.True( Instance == Unit.Default );
                Assert.Equal( Instance, Unit.Default );
            }
        }

        /// <summary>
        /// Tests of the inequality operator.
        /// </summary>
        
        public class InequalityOperator
        {
            /// <summary>
            /// Instance under test.
            /// </summary>

            Unit Instance = new Unit();

            /// <summary>
            /// Reports as equal when compared to itself.
            /// </summary>

            [Fact]
            public void ReturnsFalse_WhenComparedToSelf()
            {
                #pragma warning disable CS1718
                Assert.False( Instance != Instance );
                #pragma warning restore CS1718
            }

            /// <summary>
            /// Reports as equal when compared to the default instance.
            /// </summary>

            [Fact]
            public void ReturnsFalse_WhenComparedToDefault()
            {
                Assert.False( Instance != Unit.Default );
            }
        }
    }
}