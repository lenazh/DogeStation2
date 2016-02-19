﻿using System;
using SystemWrapper.Configuration;
using SystemWrapper.IO;
using Utils.Configuration;
using System.IO;

namespace Utils.DataManager
{
    class SampleDatasetInfo : DatasetInfo, IDatasetInfo
    {
        public SampleDatasetInfo(DateTime time, IConfigurationManagerWrap config,
            IZipFile zip, IFileWrap file, IDirectoryWrap dir, IPathWrap path) 
            : base(time, config, zip, file, dir, path) { }

        /* Returns the remote path where to upload the file. */
        override public string RemotePath
        {
            get
            {
                return string.Format(@"Signal Samples\{0}", Settings.SampleName);
            }
        }

        /* Returns the archive name */
        public override string ZipFileName
        {
            get
            {
                return Path.GetFileName(Settings.SampleName);
            }
        }
    }
}
