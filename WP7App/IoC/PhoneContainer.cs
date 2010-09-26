// From http://www.codeplex.com/Project/Download/FileDownload.aspx?ProjectName=caliburnmicro&DownloadId=140976

using System;
using Caliburn.Micro;

namespace WP7App
{
    public class PhoneContainer : SimpleContainer
    {
        public PhoneContainer()
        {
            Activator = new InstanceActivator(type => GetInstance(type, null));
        }

        public InstanceActivator Activator { get; private set; }

        protected override object ActivateInstance(Type type, object[] args)
        {
            return Activator.ActivateInstance(base.ActivateInstance(type, args));
        }
    }
}