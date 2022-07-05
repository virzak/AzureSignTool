using System;
using System.Runtime.InteropServices;

namespace AzureSign.Core.Interop
{
    [type: StructLayout(LayoutKind.Sequential)]
    internal struct SIGNER_CERT_STORE_INFO
    {
        public uint cbSize;
        public IntPtr pSigningCert;
        public SignerCertStoreInfoFlags dwCertPolicy;
        public IntPtr hCertStore;

        public SIGNER_CERT_STORE_INFO(IntPtr pSigningCert, SignerCertStoreInfoFlags dwCertPolicy, IntPtr hCertStore)
        {
            this.cbSize = (uint)Marshal.SizeOf<SIGNER_CERT_STORE_INFO>();
            this.pSigningCert = pSigningCert;
            this.dwCertPolicy = dwCertPolicy;
            this.hCertStore = hCertStore;
        }
    }

    [type: Flags]
    internal enum SignerCertStoreInfoFlags
    {

        SIGNER_CERT_POLICY_CHAIN = 0x02,
        SIGNER_CERT_POLICY_CHAIN_NO_ROOT = 0x08,
        SIGNER_CERT_POLICY_STORE = 0x01
    }
}
