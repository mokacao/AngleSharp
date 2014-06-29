﻿namespace AngleSharp.DOM.Html
{
    using System;

    /// <summary>
    /// Represents the base class for frame owned elements.
    /// </summary>
    abstract class HTMLFrameOwnerElement : HTMLElement
    {
        #region ctor

        internal HTMLFrameOwnerElement()
        {
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the status if the element can contain a range endpoint.
        /// </summary>
        public Boolean CanContainRangeEndpoint
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the width of the frame.
        /// </summary>
        public Int32 DisplayWidth
        {
            get { return ToInteger(GetAttribute(AttributeNames.Width), 0); }
            set { SetAttribute(AttributeNames.Width, value.ToString()); }
        }

        /// <summary>
        /// Gets the height of the frame.
        /// </summary>
        public Int32 DisplayHeight
        {
            get { return ToInteger(GetAttribute(AttributeNames.Height), 0); }
            set { SetAttribute(AttributeNames.Height, value.ToString()); }
        }

        /// <summary>
        /// Gets or sets the frame margin width, in pixels.
        /// </summary>
        public Int32 MarginWidth
        {
            get { return ToInteger(GetAttribute(AttributeNames.MarginWidth), 0); }
            set { SetAttribute(AttributeNames.MarginWidth, value.ToString()); }
        }

        /// <summary>
        /// Gets or sets the frame margin height, in pixels.
        /// </summary>
        public Int32 MarginHeight
        {
            get { return ToInteger(GetAttribute(AttributeNames.MarginHeight), 0); }
            set { SetAttribute(AttributeNames.MarginHeight, value.ToString()); }
        }

        #endregion
    }
}
