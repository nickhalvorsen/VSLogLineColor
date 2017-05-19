//------------------------------------------------------------------------------
// <copyright file="LogLineColorerFormat.cs" company="Company">
//     Copyright (c) Company.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

using System.ComponentModel.Composition;
using System.Windows.Media;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;

namespace LogLineColorer
{
    /// <summary>
    /// Defines an editor format for the LogLineColorer type that has a purple background
    /// and is underlined.
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "LogLineColorer")]
    [Name("LogLineColorer")]
    [UserVisible(true)] // This should be visible to the end user
    [Order(After = Priority.High)] 
    internal sealed class LogLineColorerFormat : ClassificationFormatDefinition
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LogLineColorerFormat"/> class.
        /// </summary>
        public LogLineColorerFormat()
        {
            this.DisplayName = "logger.log lines"; // Human readable version of the name
            this.ForegroundColor = Colors.DarkSlateGray;
        }
    }
}
