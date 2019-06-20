using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace MiChofer.UI.CustomRenderers
{
    public class RatingSlider : StackLayout
    {
        public static readonly BindableProperty SelectedPositionProperty = BindableProperty.Create(nameof(SelectedPosition), typeof(int), typeof(RatingSlider), 0);

        public int SelectedPosition
        {
            get { return (int)GetValue(SelectedPositionProperty); }
            set { SetValue(SelectedPositionProperty, value); }
        }


        public static readonly BindableProperty IsRatingEnabledProperty = BindableProperty.Create(nameof(IsRatingEnabled), typeof(bool), typeof(RatingSlider), true);

        public bool IsRatingEnabled
        {
            get { return (bool)GetValue(IsRatingEnabledProperty); }
            set { SetValue(IsRatingEnabledProperty, value); }
        }

        public static readonly BindableProperty ItemSpacingProperty = BindableProperty.Create(nameof(ItemSpacing), typeof(double), typeof(RatingSlider), (double)5.0f);

        public double ItemSpacing
        {
            get { return (double)GetValue(ItemSpacingProperty); }
            set { SetValue(ItemSpacingProperty, value); }
        }


        public static readonly BindableProperty NumberOfItemsProperty = BindableProperty.Create(nameof(NumberOfItems), typeof(int), typeof(RatingSlider), 5);

        public int NumberOfItems
        {
            get { return (int)GetValue(NumberOfItemsProperty); }
            set { SetValue(NumberOfItemsProperty, value); }
        }

        public static readonly BindableProperty ItemHeightProperty = BindableProperty.Create(nameof(ItemHeight), typeof(double), typeof(RatingSlider), (double)20.0f);

        public double ItemHeight
        {
            get { return (double)GetValue(ItemHeightProperty); }
            set { SetValue(ItemHeightProperty, value); }
        }

       
        public static readonly BindableProperty ItemSelectedImageProperty = BindableProperty.Create(nameof(ItemSelectedImage), typeof(string), typeof(RatingSlider), "star_selected.png");

        public string ItemSelectedImage
        {
            get { return (string)GetValue(ItemSelectedImageProperty); }
            set { SetValue(ItemSelectedImageProperty, value); }
        }

        public static readonly BindableProperty ItemUnselectedImageProperty = BindableProperty.Create(nameof(ItemUnselectedImage), typeof(string), typeof(RatingSlider), "star_unselected.png");

        public string ItemUnselectedImage
        {
            get { return (string)GetValue(ItemUnselectedImageProperty); }
            set { SetValue(ItemUnselectedImageProperty, value); }
        }

        public event EventHandler<SelectedPositionChangedEventArgs> OnSelectedPositionChanged = delegate { };
        
        IList<Image> images;
        public RatingSlider()
        {
            //HorizontalOptions = LayoutOptions.FillAndExpand;
            WidthRequest = 50;
            images = new List<Image>();

            //RowDefinitions.Add(new RowDefinition() { Height = new GridLength(ItemHeight, GridUnitType.Absolute) });
            Orientation = StackOrientation.Horizontal;

            SetupItems();
            //ColumnSpacing = ItemSpacing;

        }

        void SetupItems()
        {
            images.Clear();
            Children.Clear();
            //ColumnDefinitions.Clear();

            for (int i = 0; i < NumberOfItems; i++)
            {
               // ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(1, GridUnitType.Star) });
                var box = new Image() { WidthRequest = 15, BackgroundColor = Color.Transparent /*, CornerRadius = ItemCornerRadius*/};
                images.Add(box);
                this.Children.Add(box);
                //Children.Add(box, i, 0);
            }
            UpdatePositionColor();
        }


        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);

            if (propertyName == ItemSpacingProperty.PropertyName)
            {
                //ColumnSpacing = ItemSpacing;
            }
            else if (propertyName == SelectedPositionProperty.PropertyName || propertyName == ItemSelectedImageProperty.PropertyName ||propertyName == ItemUnselectedImageProperty.PropertyName)
            {
                if(IsRatingEnabled)
                    UpdatePositionColor();
            }
            else if (propertyName == NumberOfItemsProperty.PropertyName)
            {
                SetupItems();
            }

        }


        public void UpdatePositionColor()
        {
            if (SelectedPosition >= 1 && images.Count >= SelectedPosition)
            {
                for (int p = 0; p < images.Count; p++)
                {
                    if ((p + 1) <= SelectedPosition)
                    {
                        images[p].Source = ItemSelectedImage;
                    }
                    else
                    {
                        images[p].Source = ItemUnselectedImage;
                    }
                }

            }
            else
            {
                for (int p = 0; p < images.Count; p++)
                {
                    images[p].Source = ItemUnselectedImage;
                }
            }
        }


        public void SetSelectedPosition(int position)
        {
            OnSelectedPositionChanged(this, new SelectedPositionChangedEventArgs(position));

            SelectedPosition = position;


        }
    }
}
