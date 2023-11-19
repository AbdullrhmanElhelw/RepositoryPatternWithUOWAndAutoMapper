using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RepositoryPatternWithUOW.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Seeding_Data_To_All_Tables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Bio", "Name", "Surname" },
                values: new object[,]
                {
                    { 1, "Experienced software engineer with a passion for building scalable and efficient applications.", "John", "Doe" },
                    { 2, "Author of best-selling programming books and contributor to open-source projects.", "Jane", "Smith" },
                    { 3, "Front-end developer with expertise in creating intuitive and responsive user interfaces.", "Alex", "Johnson" },
                    { 4, "Data scientist specializing in machine learning and predictive analytics.", "Eva", "Brown" },
                    { 5, "Full-stack developer with a focus on creating robust and secure web applications.", "Michael", "White" },
                    { 6, "Backend developer specializing in designing and optimizing database systems.", "Sarah", "Lopez" },
                    { 7, "DevOps engineer automating deployment processes for efficient and reliable software delivery.", "Chris", "Garcia" },
                    { 8, "Cybersecurity expert committed to ensuring the integrity and security of digital systems.", "Emily", "Miller" },
                    { 9, "Mobile app developer creating innovative and user-friendly applications for iOS and Android.", "David", "Wang" },
                    { 10, "UI/UX designer passionate about creating visually appealing and intuitive user interfaces.", "Rachel", "Chen" },
                    { 11, "Software architect with over 15 years of experience in designing scalable and maintainable systems. Published author and conference speaker.", "Aiden", "Williams" },
                    { 12, "Machine learning researcher and data scientist. Contributed to cutting-edge research projects in natural language processing and computer vision.", "Olivia", "Martinez" },
                    { 13, "Front-end wizard crafting delightful and responsive user interfaces. Open-source contributor and advocate for web accessibility.", "Lucas", "Taylor" },
                    { 14, "Blockchain developer and smart contract specialist. Enthusiastic about decentralized applications and the future of finance.", "Sophia", "Lee" },
                    { 15, "Embedded systems engineer working on IoT solutions. Passionate about the intersection of hardware and software.", "Jackson", "Nguyen" },
                    { 16, "Software developer with a focus on building scalable and maintainable backend systems. Enjoys solving complex problems and mentoring junior developers.", "Joseph", "Albari" },
                    { 17, "Robert C. Martin, also known as Uncle Bob, is a software engineer and author. He is a key figure in the development of Agile methodologies and a proponent of clean code principles.", "Uncle", "Bob" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Books covering various programming languages, software development methodologies, and coding practices.", "Programming" },
                    { 2, "Explore the practical aspects of cloud computing and its applications in modern IT environments.", "Cloud Computing" },
                    { 3, "Books focusing on front-end and back-end development, covering web technologies and frameworks.", "Web Development" },
                    { 4, "Discover the world of artificial intelligence, including machine learning, neural networks, and AI applications.", "Artificial Intelligence" },
                    { 5, "Essential guides for mastering data science concepts, analytics, and machine learning algorithms.", "Data Science" },
                    { 6, "Books on developing mobile applications, exploring frameworks, and best practices for iOS and Android.", "Mobile Development" },
                    { 7, "Learn about cybersecurity fundamentals, threats, and countermeasures to protect digital assets.", "Cybersecurity" },
                    { 8, "Explore the transformative potential of blockchain technology and its applications in various industries.", "Blockchain" },
                    { 9, "Books focusing on user experience (UX) and user interface (UI) design principles for creating intuitive products.", "UX/UI Design" },
                    { 10, "Comprehensive guides on designing embedded systems for various applications, including IoT solutions.", "Embedded Systems" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "CategoryId", "Description", "Isbn", "Price", "PublishedOn", "Title" },
                values: new object[,]
                {
                    { 1, 1, 1, "A comprehensive guide to software development and best coding practices.", "978-1234567890", 29.99m, new DateTime(2022, 1, 15, 0, 0, 0, 0, DateTimeKind.Utc), "The Art of Coding" },
                    { 2, 2, 5, "Explore the fundamentals of data science and its applications.", "978-0987654321", 39.99m, new DateTime(2021, 9, 20, 0, 0, 0, 0, DateTimeKind.Utc), "Data Science Essentials" },
                    { 3, 3, 3, "Learn advanced techniques for creating modern and responsive user interfaces.", "978-9876543210", 34.99m, new DateTime(2021, 11, 30, 0, 0, 0, 0, DateTimeKind.Utc), "Mastering Front-End Development" },
                    { 4, 4, 8, "Discover the transformative potential of blockchain technology.", "978-1357902468", 44.99m, new DateTime(2022, 3, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Blockchain Revolution" },
                    { 5, 5, 7, "A practical guide to securing web applications against cyber threats.", "978-5678901234", 32.99m, new DateTime(2022, 5, 25, 0, 0, 0, 0, DateTimeKind.Utc), "Web Security Handbook" },
                    { 6, 9, 6, "Build cross-platform mobile apps using the Flutter framework.", "978-0123456789", 37.99m, new DateTime(2022, 2, 5, 0, 0, 0, 0, DateTimeKind.Utc), "Mobile App Development with Flutter" },
                    { 7, 12, 4, "Apply artificial intelligence and machine learning techniques to real-world problems.", "978-5432109876", 49.99m, new DateTime(2021, 12, 18, 0, 0, 0, 0, DateTimeKind.Utc), "AI and Machine Learning in Practice" },
                    { 8, 17, 1, "Explore the principles and practices of writing clean and maintainable code.", "978-8765432109", 42.99m, new DateTime(2021, 10, 8, 0, 0, 0, 0, DateTimeKind.Utc), "" },
                    { 9, 15, 10, "A comprehensive guide to designing embedded systems for various applications.", "978-1928374650", 36.99m, new DateTime(2022, 4, 12, 0, 0, 0, 0, DateTimeKind.Utc), "Embedded Systems Design" },
                    { 10, 10, 9, "Learn the essential principles of user experience design for creating intuitive and user-friendly products.", "978-7654321098", 31.99m, new DateTime(2022, 6, 28, 0, 0, 0, 0, DateTimeKind.Utc), "UX Design Principles" },
                    { 11, 8, 7, "An introductory guide to essential concepts in cybersecurity and online privacy.", "978-9876543211", 28.99m, new DateTime(2021, 8, 15, 0, 0, 0, 0, DateTimeKind.Utc), "Cybersecurity Fundamentals" },
                    { 12, 11, 2, "Explore the practical aspects of cloud computing and its applications in modern IT environments.", "978-8765432101", 45.99m, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Utc), "Cloud Computing: A Practical Approach" },
                    { 13, 6, 3, "Learn the fundamentals of game development and create your own interactive experiences.", "978-5678901235", 39.99m, new DateTime(2022, 3, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Game Development Essentials" },
                    { 14, 2, 5, "Master the use of Python for data analysis, visualization, and machine learning.", "978-5432109877", 36.99m, new DateTime(2022, 1, 5, 0, 0, 0, 0, DateTimeKind.Utc), "Python for Data Analysis" },
                    { 15, 7, 6, "A comprehensive guide to implementing DevOps practices for faster and more reliable software delivery.", "978-0123456788", 42.99m, new DateTime(2021, 10, 20, 0, 0, 0, 0, DateTimeKind.Utc), "DevOps Handbook" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
