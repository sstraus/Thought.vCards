
/* =======================================================================
 * vCard Library for .NET
 * Copyright (c) 2007-2009 David Pinch; http://wwww.thoughtproject.com
 * See LICENSE.TXT for licensing information.
 * ======================================================================= */

using System;
using System.Collections.Generic;

namespace Thought.vCards
{

    /// <summary>
    ///     An social profile in a <see cref="vCard"/>.
    /// </summary>
    /// <seealso cref="vCardSocialProfileCollection"/>
    /// <seealso cref="vCardSocialProfileType"/>
    public class vCardSocialProfile
    {

        private string address;
        private vCardSocialProfileType profileType;
        private bool isPreferred;

        /// <summary>
        ///     Creates a new <see cref=" vCardSocialProfile"/>.
        /// </summary>
        public vCardSocialProfile()
        {
            this.address = string.Empty;
            this.profileType = vCardSocialProfileType.Other;
        }


        /// <summary>
        ///     Creates a new Internet <see cref=" vCardSocialProfile"/>.
        /// </summary>
        /// <param name="address">
        ///     The Internet social address.
        /// </param>
        public vCardSocialProfile(string address)
        {
            this.address = address ?? string.Empty;
            this.profileType = vCardSocialProfileType.Other;
        }


        /// <summary>
        ///     Creates a new <see cref=" vCardSocialProfile"/> of the specified type.
        /// </summary>
        /// <param name="address">
        ///     The site address.
        /// </param>
        /// <param name="ProfileType">
        ///     The type of social profile address.
        /// </param>
        public vCardSocialProfile(string address, vCardSocialProfileType ProfileType)
        {
            this.address = address;
            this.profileType = ProfileType;
        }


        /// <summary>
        ///     The social address.
        /// </summary>
        /// <remarks>
        ///     The format of the social address is not validated by the class.
        /// </remarks>
        public string Address
        {
            get
            {
                return this.address ?? string.Empty;
            }
            set
            {
                this.address = value;
            }
        }
        /// <summary>
        /// Custom Attributes starting with X-
        /// </summary>
        public Dictionary<string, string> Attributes { get; set; }

        /// <summary>
        ///     The social address type.
        /// </summary>
        public vCardSocialProfileType ProfileType
        {
            get
            {
                return this.profileType;
            }
            set
            {
                this.profileType = value;
            }
        }


        /// <summary>
        ///     Indicates a preferred (top priority) social address.
        /// </summary>
        public bool IsPreferred
        {
            get
            {
                return this.isPreferred;
            }
            set
            {
                this.isPreferred = value;
            }
        }

        /// <summary>
        /// the Username of the social profile
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public string UserName
        {
            get { return (Attributes == null) ? null : Attributes["X-USER"]; }
            set
            {
                if (Attributes == null) Attributes = new Dictionary<string, string>();
                Attributes.Add("X-USER", value);
            }
        }

        /// <summary>
        ///     Builds a string that represents the social address.
        /// </summary>
        public override string ToString()
        {
            return this.address;
        }
    }

}