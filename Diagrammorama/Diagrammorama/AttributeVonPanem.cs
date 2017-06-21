using System;

namespace Diagrammorama
{
    class AttributeVonPanem : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AttributeVonPanem"/> class.
        /// </summary>
        /// <param name="filename">The filename.</param>
        public AttributeVonPanem(string filename)
        {
            Filename = filename;
        }

        /// <summary>
        /// Gets the filename.
        /// </summary>
        /// <value>The filename.</value>
        /// <remarks>
        /// For sub folders, use '/' as path delimiter.
        /// This is then replaced with the current platforms path separator later in the process.
        /// </remarks>
        public string Filename { get; }
    }
}
