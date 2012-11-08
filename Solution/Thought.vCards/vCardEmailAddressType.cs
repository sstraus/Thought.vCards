
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
    ///     Identifies the type of email address in a vCard.
    /// </summary>
    /// <seealso cref="vCardEmailAddress"/>
    [Flags]
    public enum vCardEmailAddressType
    {

        /// <summary>
        ///     An Internet (SMTP) mail (default) address.
        /// </summary>
        Internet = 1,


        /// <summary>
        ///     An America On-Line email address.
        /// </summary>
        AOL = 2,


        /// <summary>
        ///     An AppleLink email address.
        /// </summary>
        AppleLink = 4,


        /// <summary>
        ///     An AT&amp;T Mail email address
        /// </summary>
        AttMail = 8,


        /// <summary>
        ///     A CompuServe Information Service (CIS) email address.
        /// </summary>
        CompuServe = 16,


        /// <summary>
        ///     An eWorld email address.
        /// </summary>
        /// <remarks>
        ///     eWorld was an online service by Apple Computer in the mid 1990s.
        ///     It was officially shut down on March 31, 1996.
        /// </remarks>
        eWorld = 32,


        /// <summary>
        ///     An IBM Mail email address.
        /// </summary>
        IBMMail = 64,


        /// <summary>
        ///     An MCI Mail email address.
        /// </summary>
        MCIMail = 128,


        /// <summary>
        ///     A PowerShare email address.
        /// </summary>
        PowerShare = 256,


        /// <summary>
        ///     A Prodigy Information Service email address.
        /// </summary>
        Prodigy = 512,


        /// <summary>
        ///     A telex email address.
        /// </summary>
        Telex = 1024,


        /// <summary>
        ///     An X.400 service email address.
        /// </summary>
        X400 = 2048,

        /// <summary>
        ///     V3 for Work
        /// </summary>
        Work = 4096,

        /// <summary>
        ///     V3 for Home
        /// </summary>
        Home = 8192,

        /// <summary>
        ///     V3 for Other
        /// </summary>
        Other = 16348
    }

}