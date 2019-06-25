﻿namespace ClashLand.Core.Consoles
{
    using System.Diagnostics;
    using System.IO;
    using System.Text;

    public class RedisTextWriter : TextWriter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RedisTextWriter"/> class.
        /// </summary>
        public RedisTextWriter()
        {
            // RedisTextWriter.
        }

        /// <summary>
        /// En cas de substitution dans une classe dérivée, retourne l'encodage de caractères dans lequel la sortie est écrite.
        /// </summary>
        public override Encoding Encoding
        {
            get
            {
                return new ASCIIEncoding();
            }
        }

        /// <summary>
        /// Writes the specified message.
        /// </summary>
        /// <param name="Message">The message.</param>
        public override void Write(string Message)
        {
            Debug.Write(Message);
        }

        /// <summary>
        /// Writes the line.
        /// </summary>
        /// <param name="Message">The message.</param>
        public override void WriteLine(string Message)
        {
            Debug.WriteLine("[*] " + Message);
        }
    }
}