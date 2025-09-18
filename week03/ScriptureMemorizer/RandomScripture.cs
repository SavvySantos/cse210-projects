using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;


public class RandomScriptures
{
    private List<Scripture> _scriptures;
    private Random _random;

    public RandomScriptures()
    {
        _random = new Random();
        _scriptures = new List<Scripture>
        {
        new Scripture("2 Nephi 22:2 ", " 2 Behold, God is my salvation; I will trust, and not be afraid; for the Lord Jehovah is my strength and my song; he also has become my salvation."),
        new Scripture("3 Nephi 11:14 ", " 14 Arise and come forth unto me, that ye may thrust your hands into my side, and also that ye may feel the prints of the nails in my hands and in my feet, that ye may know that I am the God of Israel, and the God of the whole earth, and have been slain for the sins of the world."),
        new Scripture("1 Nephi 3:7 ", " 7 And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."),
        new Scripture("1 Nephi 4:6 ", " 6 And I was led by the Spirit, not knowing beforehand the things which I should do."),
        new Scripture("1 Nephi 6:4 ", " 4 For the fulness of mine intent is that I may persuade men to come unto the God of Abraham, and the God of Isaac, and the God of Jacob, and be saved."),
        new Scripture("Mosiah 2:17 ", " 17 And behold, I tell you these things that ye may learn wisdom; that ye may learn that when ye are in the service of your fellow beings ye are only in the service of your God."),
        new Scripture("Moroni 10:3-5 ", " 3 Behold, I would exhort you that when ye shall read these things, if it be wisdom in God that ye should read them, that ye would remember how merciful the Lord hath been unto the children of men, from the creation of Adam even down until the time that ye shall receive these things, and ponder it in your hearts. 4 And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost. 5 And by the power of the Holy Ghost ye may know the truth of all things."),
        new Scripture("Helaman 3:34-35 ", " 34 And they were lifted up in pride, even to the persecution of many of their brethren. Now this was a great evil, which did cause the more humble part of the people to suffer great persecutions, and to wade through much affliction. 35 Nevertheless they did fast and pray oft, and did wax stronger and stronger in their humility, and firmer and firmer in the faith of Christ, unto the filling their souls with joy and consolation, yea, even to the purifying and the sanctification of their hearts, which sanctification cometh because of their yielding their hearts unto God."),
        new Scripture("Alma 26:1 ", " 1 And now, these are the words of Ammon to his brethren, which say thus: My brothers and my brethren, behold I say unto you, how great reason have we to rejoice; for could we have supposed when we started from the land of Zarahemla that God would have granted unto us such great blessings?")
   };

    }
    public Scripture GetRandomScripture()
    {
        if (_scriptures.Count == 0)
        {
            return null;
        }

        int index = _random.Next(0, _scriptures.Count);
        return _scriptures[index];
    }

}
