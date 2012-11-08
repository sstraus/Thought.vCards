
/* =======================================================================
 * vCard Library for .NET
 * Copyright (c) 2007-2009 David Pinch; http://wwww.thoughtproject.com
 * Support for vCard 3.0 added by Stefano Straus
 * See LICENSE.TXT for licensing information.
 * ======================================================================= */

using System;

namespace Thought.vCards
{

    /// <summary>
    ///     Identifies the type of social profilein a vCard.
    /// </summary>
    /// <seealso cref="vCardSocialProfile"/>    
    public enum vCardSocialProfileType
    {

        /// <summary>
        ///     Twitter.
        /// </summary>
        Twitter = 1,


        /// <summary>
        ///     Facebook.
        /// </summary>
        Facebook,


        /// <summary>
        ///     linkedin.
        /// </summary>
        Linkedin,


        /// <summary>
        ///     flickr.
        /// </summary>
        Flickr,


        /// <summary>
        ///     myspace.
        /// </summary>
        Myspace,

        /// <summary>
        ///     sinaweibo.
        /// </summary>
        Sinaweibo,


        /// <summary>
        ///     Other.
        /// </summary>
        Other
    }

}