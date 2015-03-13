using System;

namespace ACMICPCTeam
{
    class Program
    {
        static void Main(string[] args)
        {
            // Parse Input
            string input = Console.ReadLine();
            string[] elements = input.Split(' ');
            int numberOfPeople = Convert.ToInt32(elements[0]);
            int numberOfTopics = Convert.ToInt32(elements[1]);
            string[] topicsEachPersonKnows = new string[numberOfPeople];

            // Populate array with topics each member knows
            for (int i = 0; i < numberOfPeople; i++)
            {
                topicsEachPersonKnows[i] = Console.ReadLine();
            }

            // Set defaults for the maximum number of topics a two man team knows and the number of two man teams
            int maximumNumberOfTopics = 0;
            int numberOfTwoPersonTeams = 1;

            // Cycle through every possible two man team combination
            for (int i = 0; i < ( numberOfPeople - 1); i++)
            {
                for (int j = i + 1; j < numberOfPeople; j++)
                {
                    string member1 = topicsEachPersonKnows[i];
                    string member2 = topicsEachPersonKnows[j];
                    int tempNumberOfTopics = 0;
                    for (int currentTopic = 0; currentTopic < numberOfTopics; currentTopic++)
                    {
                        if (member1[currentTopic] == '1') // If team member one knows the topic
                        {
                            tempNumberOfTopics++; // Increment number of topics
                        }
                        else if (member2[currentTopic] == '1') // Otherwise, if member 2 knows the topic
                        {
                            tempNumberOfTopics++; // Increment the number of topics
                        }
                    }
                    if (tempNumberOfTopics > maximumNumberOfTopics) // If temp number of topics is greater than the current maximum
                    {
                        maximumNumberOfTopics = tempNumberOfTopics; // Update the maximum
                        numberOfTwoPersonTeams = 1; // Reset two person team counter
                    }
                    else if (tempNumberOfTopics == maximumNumberOfTopics) // If temp number of topics is equal to the current maximum
                    {
                        numberOfTwoPersonTeams++; // Increment two person team counter
                    }
                }
            }

            // Output
            Console.WriteLine(maximumNumberOfTopics);
            Console.WriteLine(numberOfTwoPersonTeams);

        }
    }
}
