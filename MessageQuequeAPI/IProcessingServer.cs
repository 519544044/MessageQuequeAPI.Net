using System;

namespace MessageQuequeAPI
{
    /// <summary>
    /// A process thread abstract of job process.
    /// </summary>
    public interface IProcessingServer : IDisposable
    {
        void Pulse();

        void Start();
    }
}