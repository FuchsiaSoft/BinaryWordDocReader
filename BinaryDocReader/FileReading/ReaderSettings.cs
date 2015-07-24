﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FuchsiaSoft.BinaryWordDocReader.FileReading
{
    /// <summary>
    /// Controls the settings of a BinaryDocReader
    /// </summary>
    public class ReaderSettings
    {
        /// <summary>
        /// Include the main document body
        /// </summary>
        public bool IncludeMain { get; set; }
        /// <summary>
        /// Include the document header
        /// </summary>
        public bool IncludeHeader { get; set; }
        /// <summary>
        /// Include the document footnote
        /// </summary>
        public bool IncludeFootnote { get; set; }
        /// <summary>
        /// Include the document endnote
        /// </summary>
        public bool IncludeEndNote { get; set; }
        /// <summary>
        /// Include the document comments
        /// </summary>
        public bool IncludeComments { get; set; }
        /// <summary>
        /// Include textboxes in the main document
        /// </summary>
        public bool IncludeMainTextBox { get; set; }
        /// <summary>
        /// Include textboxes in the header
        /// </summary>
        public bool IncludeHeaderTextBox { get; set; }

        /// <summary>
        /// The default reader settings
        /// </summary>
        public static ReaderSettings Default
        {
            get
            {
                return new ReaderSettings()
                {
                    IncludeMain = true,
                    IncludeHeader = true,
                    IncludeEndNote = true,
                    IncludeFootnote = true,
                    IncludeMainTextBox = true,
                    IncludeHeaderTextBox = true,
                    IncludeComments = false
                };
            }
        }
    }
}
