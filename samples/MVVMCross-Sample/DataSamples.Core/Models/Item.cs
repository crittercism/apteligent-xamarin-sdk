using Intersoft.Crosslight;
using System;
using System.Collections.Generic;

namespace DataSamples.Models
{
    [Serializable]
    public partial class Item : ModelBase
    {
        private string _name;
        private string _image;
        private int _categoryId;
        private Category _category;
        private int _quantity;
        private decimal _price;
        private string _location;
        private string _description;
        private string _serialNumber;
        private string _notes;
        private bool _isSold;
        private DateTime _purchaseDate;
        private DateTime _soldDate;
		internal byte[] _largeImage;
		internal byte[] _thumbnailImage;

        public byte[] ThumbnailImage
		{
			get
			{
				return _thumbnailImage;
			}
			set
			{
				if (_thumbnailImage != value)
				{
					_thumbnailImage = value;
					OnPropertyChanged("ThumbnailImage");
				}
			}
		}

        public byte[] LargeImage
		{
			get
			{
				return _largeImage;
			}
			set
			{
				_largeImage = value;
				this.ThumbnailImage = value; // re-scale image at servre

				if (value == null)
					this.Image = null;
				else
					this.Image = "image_" + this.Name + ".jpg";

				OnPropertyChanged("LargeImage");
			}
		}

        public string Notes
        {
            get { return _notes; }
            set
            {
                if (_notes != value)
                {
                    _notes = value;
                    OnPropertyChanged("Notes");
                }
            }
        }

        public DateTime SoldDate
        {
            get { return _soldDate; }
            set
            {
                if (_soldDate != value)
                {
                    _soldDate = value;
                    OnPropertyChanged("SoldDate");
                }
            }
        }

        public bool IsSold
        {
            get { return _isSold; }
            set
            {
                if (_isSold != value)
                {
                    _isSold = value;
                    OnPropertyChanged("IsSold");

					if (_isSold)
					{
						if (this.SoldDate == DateTime.MinValue)
							this.SoldDate = DateTime.Today;
					}
                }
            }
        }

        public DateTime PurchaseDate
        {
            get { return _purchaseDate; }
            set
            {
                if (_purchaseDate != value)
                {
                    _purchaseDate = value;
                    OnPropertyChanged("PurchaseDate");
                }
            }
        }

        public string SerialNumber
        {
            get { return _serialNumber; }
            set
            {
                if (_serialNumber != value)
                {
                    _serialNumber = value;
                    OnPropertyChanged("SerialNumber");
                }
            }
        }

        public string Description
        {
            get { return _description; }
            set
            {
                if (_description != value)
                {
                    _description = value;
                    OnPropertyChanged("Description");
                }
            }
        }

        public string Location
        {
            get { return _location; }
            set
            {
                if (_location != value)
                {
                    _location = value;
                    OnPropertyChanged("Location");
                }
            }
        }

        public decimal Price
        {
            get { return _price; }
            set
            {
                if (_price != value)
                {
                    _price = value;
                    ClearError("Price");
                    OnPropertyChanged("Price");
                }
            }
        }

        public int Quantity
        {
            get { return _quantity; }
            set
            {
                if (_quantity != value)
                {
                    _quantity = value;
                    ClearError("Quantity");
                    OnPropertyChanged("Quantity");
                }
            }
        }


        public Category Category
        {
            get { return _category; }
            set
            {
                if (_category != value)
                {
                    _category = value;
                    ClearError("Category");
                    OnPropertyChanged("Category");

					if (_category != null)
						_categoryId = _category.Id;
                }
            }
        }

        public int CategoryId
        {
            get { return _categoryId; }
            set
            {
                if (_categoryId != value)
                {
                    _categoryId = value;
                    ClearError("CategoryId");
                    OnPropertyChanged("CategoryId");
                }
            }
        }

        public string Image
        {
            get { return _image; }
            set
            {
                if (_image != value)
                {
                    _image = value;
                    OnPropertyChanged("Image");
                }
            }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    ClearError("Name");
                    OnPropertyChanged("Name");
                }
            }
        }

        public override void Validate()
        {
            this.ClearAllErrors();

            if (string.IsNullOrEmpty(this.Name))
                this.SetError("Please enter the name for this item", "Name");

            if (string.IsNullOrEmpty(this.Location))
                this.SetError("Please specify the location for this item", "Location");

            if (this.CategoryId == 0)
                this.SetError("Please specify the category for this item", "CategoryId");

            if (this.Quantity < 1)
                this.SetError("Please specify a valid quantity for this item, i.e., 1", "Quantity");

            if (this.Price < 1)
                this.SetError("Please specify a valid price for this item, i.e, 500", "Quantity");
        }
    }
}
