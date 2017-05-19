//------------------------------------------------------------------------------
// <copyright file="LogLineColorerClassificationDefinition.cs" company="Company">
//     Copyright (c) Company.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

using System.ComponentModel.Composition;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;

namespace LogLineColorer
{
    /// <summary>
    /// Classification type definition export for LogLineColorer
    /// </summary>
    internal static class LogLineColorerClassificationDefinition
    {
        // This disables "The field is never used" compiler's warning. Justification: the field is used by MEF.
#pragma warning disable 169

        /// <summary>
        /// Defines the "LogLineColorer" classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("LogLineColorer")]
        private static ClassificationTypeDefinition typeDefinition;

#pragma warning restore 169
    }
}
