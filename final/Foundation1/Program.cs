using System;

class Program
{
    static void Main(string[] args)
    {
        Comment comment1 = new Comment();
        comment1._commentor = "Eva";
        comment1._message = "So cool!!";

        Comment comment2 = new Comment();
        comment2._commentor = "Tim";
        comment2._message = "I love tigers.";

        Comment comment6 = new Comment();
        comment6._commentor = "Brayden";
        comment6._message = "Wow.";

        Video video1 = new Video();
        video1._title = "Tigers Documentary";
        video1._author = "Bill Nye";
        video1._length = 550;

        video1._commentList.Add(comment1);
        video1._commentList.Add(comment2);
        video1._commentList.Add(comment6);

        video1.Display();

        Comment comment3 = new Comment();
        comment3._commentor = "Zach";
        comment3._message = "Great camera work.";

        Comment comment4 = new Comment();
        comment4._commentor = "Kenzie";
        comment4._message = "The seahorses are my favorite!";

        Comment comment5 = new Comment();
        comment5._commentor = "Charlie";
        comment5._message = "This was very educational.";

        Video video2 = new Video();
        video2._title = "The Pacific Ocean";
        video2._author = "National Geographic";
        video2._length = 7111;

        video2._commentList.Add(comment3);
        video2._commentList.Add(comment4);
        video2._commentList.Add(comment5);

        video2.Display();

        Comment comment7 = new Comment();
        comment7._commentor = "Eli";
        comment7._message = "This video helped me catch my first fish";

        Comment comment8 = new Comment();
        comment8._commentor = "Adam";
        comment8._message = "What kind of bait is being used?";

        Comment comment9 = new Comment();
        comment9._commentor = "user447";
        comment9._message = "Looks so peaceful";

        Comment comment10 = new Comment();
        comment10._commentor = "Fisher4Life";
        comment10._message = "This is the dream!!";

        Video video3 = new Video();
        video3._title = "Land of Deserts";
        video3._author = "Kaylee Good";
        video3._length = 3200;

        video3._commentList.Add(comment7);
        video3._commentList.Add(comment8);
        video3._commentList.Add(comment9);
        video3._commentList.Add(comment10);

        video3.Display();
    }
}