using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace System.Data.Entity.Core.Objects.SqlClient
{
    /// <summary>
    /// Contains function stubs that expose SqlServer methods in Linq to Entities.
    /// </summary>
    public static class SqlSpatialFunctions
    {
        /// <summary>
        /// Proxy for the function SqlServer.POINTGEOGRAPHY
        /// </summary>
        [EdmFunction("SqlServer", "POINTGEOGRAPHY")]
        public static System.Data.Entity.Core.Spatial.DbGeography PointGeography(System.Double? latitude, System.Double? longitude, System.Int32? spatialReferenceId)
        {
            throw EntityUtil.NotSupported(System.Data.Entity.Resources.Strings.ELinq_EdmFunctionDirectCall);
        }

        /// <summary>
        /// Proxy for the function SqlServer.ASTEXTZM
        /// </summary>
        [EdmFunction("SqlServer", "ASTEXTZM")]
        public static System.String AsTextZM(System.Data.Entity.Core.Spatial.DbGeography geographyValue)
        {
            throw EntityUtil.NotSupported(System.Data.Entity.Resources.Strings.ELinq_EdmFunctionDirectCall);
        }

        /// <summary>
        /// Proxy for the function SqlServer.BUFFERWITHTOLERANCE
        /// </summary>
        [EdmFunction("SqlServer", "BUFFERWITHTOLERANCE")]
        public static System.Data.Entity.Core.Spatial.DbGeography BufferWithTolerance(System.Data.Entity.Core.Spatial.DbGeography geographyValue, System.Double? distance, System.Double? tolerance, System.Boolean? relative)
        {
            throw EntityUtil.NotSupported(System.Data.Entity.Resources.Strings.ELinq_EdmFunctionDirectCall);
        }

        /// <summary>
        /// Proxy for the function SqlServer.ENVELOPEANGLE
        /// </summary>
        [EdmFunction("SqlServer", "ENVELOPEANGLE")]
        public static System.Double? EnvelopeAngle(System.Data.Entity.Core.Spatial.DbGeography geographyValue)
        {
            throw EntityUtil.NotSupported(System.Data.Entity.Resources.Strings.ELinq_EdmFunctionDirectCall);
        }

        /// <summary>
        /// Proxy for the function SqlServer.ENVELOPECENTER
        /// </summary>
        [EdmFunction("SqlServer", "ENVELOPECENTER")]
        public static System.Data.Entity.Core.Spatial.DbGeography EnvelopeCenter(System.Data.Entity.Core.Spatial.DbGeography geographyValue)
        {
            throw EntityUtil.NotSupported(System.Data.Entity.Resources.Strings.ELinq_EdmFunctionDirectCall);
        }

        /// <summary>
        /// Proxy for the function SqlServer.FILTER
        /// </summary>
        [EdmFunction("SqlServer", "FILTER")]
        public static System.Boolean? Filter(System.Data.Entity.Core.Spatial.DbGeography geographyValue, System.Data.Entity.Core.Spatial.DbGeography geographyOther)
        {
            throw EntityUtil.NotSupported(System.Data.Entity.Resources.Strings.ELinq_EdmFunctionDirectCall);
        }

        /// <summary>
        /// Proxy for the function SqlServer.INSTANCEOF
        /// </summary>
        [EdmFunction("SqlServer", "INSTANCEOF")]
        public static System.Boolean? InstanceOf(System.Data.Entity.Core.Spatial.DbGeography geographyValue, System.String geometryTypeName)
        {
            throw EntityUtil.NotSupported(System.Data.Entity.Resources.Strings.ELinq_EdmFunctionDirectCall);
        }

        /// <summary>
        /// Proxy for the function SqlServer.NUMRINGS
        /// </summary>
        [EdmFunction("SqlServer", "NUMRINGS")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Num", Justification = "Naming convention prescribed by OGC specification")]
        public static System.Int32? NumRings(System.Data.Entity.Core.Spatial.DbGeography geographyValue)
        {
            throw EntityUtil.NotSupported(System.Data.Entity.Resources.Strings.ELinq_EdmFunctionDirectCall);
        }

        /// <summary>
        /// Proxy for the function SqlServer.REDUCE
        /// </summary>
        [EdmFunction("SqlServer", "REDUCE")]
        public static System.Data.Entity.Core.Spatial.DbGeography Reduce(System.Data.Entity.Core.Spatial.DbGeography geographyValue, System.Double? tolerance)
        {
            throw EntityUtil.NotSupported(System.Data.Entity.Resources.Strings.ELinq_EdmFunctionDirectCall);
        }

        /// <summary>
        /// Proxy for the function SqlServer.RINGN
        /// </summary>
        [EdmFunction("SqlServer", "RINGN")]
        public static System.Data.Entity.Core.Spatial.DbGeography RingN(System.Data.Entity.Core.Spatial.DbGeography geographyValue, System.Int32? index)
        {
            throw EntityUtil.NotSupported(System.Data.Entity.Resources.Strings.ELinq_EdmFunctionDirectCall);
        }

        /// <summary>
        /// Proxy for the function SqlServer.POINTGEOMETRY
        /// </summary>
        [EdmFunction("SqlServer", "POINTGEOMETRY")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "x", Justification = "Naming convention prescribed by OGC specification")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "y", Justification = "Naming convention prescribed by OGC specification")]
        public static System.Data.Entity.Core.Spatial.DbGeometry PointGeometry(System.Double? xCoordinate, System.Double? yCoordinate, System.Int32? spatialReferenceId)
        {
            throw EntityUtil.NotSupported(System.Data.Entity.Resources.Strings.ELinq_EdmFunctionDirectCall);
        }

        /// <summary>
        /// Proxy for the function SqlServer.ASTEXTZM
        /// </summary>
        [EdmFunction("SqlServer", "ASTEXTZM")]
        public static System.String AsTextZM(System.Data.Entity.Core.Spatial.DbGeometry geometryValue)
        {
            throw EntityUtil.NotSupported(System.Data.Entity.Resources.Strings.ELinq_EdmFunctionDirectCall);
        }

        /// <summary>
        /// Proxy for the function SqlServer.BUFFERWITHTOLERANCE
        /// </summary>
        [EdmFunction("SqlServer", "BUFFERWITHTOLERANCE")]
        public static System.Data.Entity.Core.Spatial.DbGeometry BufferWithTolerance(System.Data.Entity.Core.Spatial.DbGeometry geometryValue, System.Double? distance, System.Double? tolerance, System.Boolean? relative)
        {
            throw EntityUtil.NotSupported(System.Data.Entity.Resources.Strings.ELinq_EdmFunctionDirectCall);
        }

        /// <summary>
        /// Proxy for the function SqlServer.INSTANCEOF
        /// </summary>
        [EdmFunction("SqlServer", "INSTANCEOF")]
        public static System.Boolean? InstanceOf(System.Data.Entity.Core.Spatial.DbGeometry geometryValue, System.String geometryTypeName)
        {
            throw EntityUtil.NotSupported(System.Data.Entity.Resources.Strings.ELinq_EdmFunctionDirectCall);
        }

        /// <summary>
        /// Proxy for the function SqlServer.FILTER
        /// </summary>
        [EdmFunction("SqlServer", "FILTER")]
        public static System.Boolean? Filter(System.Data.Entity.Core.Spatial.DbGeometry geometryValue, System.Data.Entity.Core.Spatial.DbGeometry geometryOther)
        {
            throw EntityUtil.NotSupported(System.Data.Entity.Resources.Strings.ELinq_EdmFunctionDirectCall);
        }

        /// <summary>
        /// Proxy for the function SqlServer.MAKEVALID
        /// </summary>
        [EdmFunction("SqlServer", "MAKEVALID")]
        public static System.Data.Entity.Core.Spatial.DbGeometry MakeValid(System.Data.Entity.Core.Spatial.DbGeometry geometryValue)
        {
            throw EntityUtil.NotSupported(System.Data.Entity.Resources.Strings.ELinq_EdmFunctionDirectCall);
        }

        /// <summary>
        /// Proxy for the function SqlServer.REDUCE
        /// </summary>
        [EdmFunction("SqlServer", "REDUCE")]
        public static System.Data.Entity.Core.Spatial.DbGeometry Reduce(System.Data.Entity.Core.Spatial.DbGeometry geometryValue, System.Double? tolerance)
        {
            throw EntityUtil.NotSupported(System.Data.Entity.Resources.Strings.ELinq_EdmFunctionDirectCall);
        }

    }
}