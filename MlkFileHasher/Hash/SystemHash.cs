using System;
using System.Security.Cryptography;

namespace MlkFileHasher.Hash
{
    public class SystemHash : IHashAlgorithm
    {
        HashAlgorithm _hash;

        public SystemHash(HashAlgorithm hash)
        {
            _hash = hash;
        }

        public void Process(byte[] buf, int count)
        {
            _hash.TransformBlock(buf, 0, count, null, 0);
        }

        public void Done()
        {
            _hash.TransformFinalBlock(new byte[0], 0, 0);
        }

        public byte[] Hash
        {
            get { return _hash.Hash; }
        }

        public void Dispose()
        {
            _hash.Dispose();
        }

        public static Func<SystemHash> GetFactory(Func<HashAlgorithm> factory)
        {
            return () => new SystemHash(factory());
        }
    }
}
