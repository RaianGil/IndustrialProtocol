using IndustrialProtocol.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialProtocol.Controllers
{
    public class Protocol
    {
        public bool get(int inStart, int inLength, Action<byte[], bool> inFunc)
        {
            try 
            { 
                // Grouping all request in a model request to exec get function
                Request.add(inStart, inLength, inFunc);
                get();
            }
            catch(Exception e)
            {
                return false;
            }
            return true;
        }
        public bool get(ReadParameters inParameters)
        {
            try
            {
                int inStart = inParameters.intLength;
                int inLength = inParameters.intLength;
                var inFunc = inParameters.actPayload;
                // Grouping all request in a model request to exec get function
                Request.add(inStart, inLength, inFunc);
                get();
            }
            catch(Exception e)
            {
                return false;
            }
            return true;
        }
        private async void get()
        {
            // Function get all request grouped in Models.Request

            // Delay for group as many request simulate
            await Task.Delay(500);
            var inParameters = Request.get();
            bool hasData;

            try
            {
                _ = inParameters.Count();
                hasData = true;
            }
            catch(Exception e) { hasData = false; }

            if(hasData)
            {
                foreach (var Paramerters in inParameters)
                {
                    int inStart = Paramerters.intStart;
                    int inLength = Paramerters.intLength;
                    Debug.WriteLine($"Start: {inStart}, Length: {inLength}");
                    var inFunc = Paramerters.actPayload;
                    FileStream flDocument = null;
                    //
                    try
                    {
                        flDocument = File.get;
                    }
                    catch (Exception e)
                    {
                        inFunc(null, false);
                        Debug.WriteLine($"Can't Opened file: {e}");
                        continue;
                    }
                    if (inLength > 0 && inLength < 11)
                    {
                        byte[] btReturn = new byte[inLength];
                        var dataToRead = new BinaryReader(flDocument);
                        dataToRead.BaseStream.Seek(inStart, SeekOrigin.Begin);
                        dataToRead.Read(btReturn, 0, inLength);

                        inFunc(btReturn, true);
                    }
                    else
                    {
                        inFunc(null, false);
                    }
                }
            }
        }
    }
}
