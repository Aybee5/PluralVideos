﻿using CommandLine;
using System;

namespace DecryptVideos.Option
{
    public class DecryptorOptions
    {
        [Option("out", Required = true, HelpText = "Output folder path")]
        public string OutputPath { get; set; }

        [Option("db", HelpText = "Database file path")]
        public string DatabasePath { get; set; } = DefaultDatabasePath;

        [Option("course", HelpText = "Course folder path")]
        public string CoursesPath { get; set; } = DefaultCoursesPath;

        [Option("trans", HelpText = "Create subtitle file along with the video")]
        public bool CreateTranscript { get; set; }

        [Option("rm", HelpText = "Remove encrypted folder after decryption")]
        public bool RemoveFolderAfterDecryption { get; set; }

        private static string DefaultDatabasePath => $@"{BasePath}\pluralsight.db";

        private static string DefaultCoursesPath => $@"{BasePath}\courses";

        private static string BasePath =>
            $@"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\Pluralsight";
    }
}
