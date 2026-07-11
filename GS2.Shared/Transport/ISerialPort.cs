using System;

#pragma warning disable IDE0130 // Namespace does not match folder structure
namespace GS2.Shared.Transport
#pragma warning restore IDE0130 // Namespace does not match folder structure
{
    public interface ISerialPort : IDisposable
    {
        /// <summary>
        /// Read timeout in milliseconds
        /// </summary>
        int ReadTimeout { get; }

        bool IsOpen { get; }

        void Open();

        void Write(string data);

        string ReadExisting();

        void DiscardInBuffer();

        void DiscardOutBuffer();
    }
}