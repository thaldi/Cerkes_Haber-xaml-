using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XLabs.Forms.Controls;
using XLabs.Platform.Services.Media;
using XLabs.Platform.Device;

namespace Cerkes_Haber.Helper
{
    public class PhotoChoiseHelper : IMediaPicker
    {
        public bool IsCameraAvailable
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool IsPhotosSupported
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool IsVideosSupported
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public EventHandler<MediaPickerErrorArgs> OnError
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public EventHandler<MediaPickerArgs> OnMediaSelected
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public Task<MediaFile> SelectPhotoAsync(CameraMediaStorageOptions options)
        {
            throw new NotImplementedException();
        }

        public Task<MediaFile> SelectVideoAsync(VideoMediaStorageOptions options)
        {
            throw new NotImplementedException();
        }

        public Task<MediaFile> TakePhotoAsync(CameraMediaStorageOptions options)
        {
            throw new NotImplementedException();
        }

        public Task<MediaFile> TakeVideoAsync(VideoMediaStorageOptions options)
        {
            throw new NotImplementedException();
        }


    }
}
