﻿using System;
using System.IO;

namespace SOLID_DIP
{
    class FormatConverter
    {
        private readonly InputParser _inputParser;
        private readonly IDocumentSerializer _documentSerializer;

        public FormatConverter(IDocumentSerializer documentSerializer, InputParser parser)
        {
            _documentSerializer = documentSerializer;
            _inputParser = parser;
        }
        internal bool ConvertFormat(string sourceFileName, string targetFileName)
        {
            string input;
            var inputRetriver = GetInputRetriever(sourceFileName);
            var inputPersister = GetInputPersister(targetFileName);
            try
            {
                input = inputRetriver.GetData(sourceFileName);
            }
            catch (FileNotFoundException)
            {
                return false;
            }

            var doc = _inputParser.ParseInput(input);
            var serializedDoc = _documentSerializer.Serilize(doc);

            try
            {
                inputPersister.PersistDocument(serializedDoc, targetFileName);
            }
            catch (AccessViolationException)
            {
                return false;
            }
            return true;
        }

        internal IInputRetriever GetInputRetriever(string sourceFileName)
        {
            if (sourceFileName.StartsWith("http"))
                return new HttpInputRetriever();
            return new FileDocumentStorage();
        }
        internal IInputPersister GetInputPersister(string targetFileName)
        {
            return new FileDocumentStorage();
        }
    }
}