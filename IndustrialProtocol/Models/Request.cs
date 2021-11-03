using System;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace IndustrialProtocol.Models
{
    class Request
    {
        private static ObservableCollection<ReadParameters> listRequest;
        static bool firstAdd;
        public static void init()
        {
            try
            {
                listRequest = null;
                listRequest = new ObservableCollection<ReadParameters>();
            }
            catch (Exception e)
            {
                Debug.WriteLine($"Error: {e}");
            }
        }
        public static void add(int inStart, int inLength, Action<byte[], bool> inFunc)
        {
            if (!firstAdd)
            {
                firstAdd = true;
                init();
            }
            listRequest.Add(new ReadParameters { intStart = inStart, intLength = inLength, actPayload = inFunc });
        }
        public static ObservableCollection<ReadParameters> get()
        {
            var outListRequest = listRequest;
            init();
            return outListRequest;
        }
    }
}
