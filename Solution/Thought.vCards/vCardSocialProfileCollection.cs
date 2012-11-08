
/* =======================================================================
 * vCard Library for .NET
 * Copyright (c) 2007-2009 David Pinch; http://wwww.thoughtproject.com
 * Support for vCard 3.0 added by Stefano Straus
 * See LICENSE.TXT for licensing information.
 * ======================================================================= */

using System;
using System.Collections.ObjectModel;

namespace Thought.vCards
{

    /// <summary>
    ///     A collection of <see cref="vCardSocialProfile"/> objects.
    /// </summary>
    /// <seealso cref="vCardSocialProfile"/>
    /// <seealso cref="vCardSocialProfileType"/>
    public class vCardSocialProfileCollection : Collection<vCardSocialProfile>
    {

        /// <summary>
        ///     Initializes a new instance of the <see cref="vCardSocialProfileCollection" />.
        /// </summary>
        public vCardSocialProfileCollection()
            : base()
        {
        }

        /// <summary>
        ///     Locates the first social address of the specified type while 
        ///     giving preference to social addresses marked as preferred.
        /// </summary>
        /// <param name="profileType">
        ///     The type of social address to locate.  This can be any 
        ///     combination of values from <see cref="vCardSocialProfileType"/>.
        /// </param>
        /// <returns>
        ///     The function returns the first preferred social address that matches
        ///     the specified type.  If the collection does not contain a preferred
        ///     social address, then it will return the first non-preferred matching
        ///     social address.  The function returns null if no matches were found.
        /// </returns>
        public vCardSocialProfile GetFirstChoice(vCardSocialProfileType profileType)
        {

            vCardSocialProfile firstNonPreferred = null;

            foreach (vCardSocialProfile profile in this)
            {

                if ((profile.ProfileType & profileType) == profileType)
                {

                    if (firstNonPreferred == null)
                        firstNonPreferred = profile;

                    if (profile.IsPreferred)
                        return profile;
                }

            }

            return firstNonPreferred;

        }

    }

}