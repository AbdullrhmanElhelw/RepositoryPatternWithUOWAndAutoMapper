﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RepositoryPatternWithUOW.Infrastructure.Context;

#nullable disable

namespace RepositoryPatternWithUOW.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231118232224_Seeding_Data_To_All_Tables")]
    partial class Seeding_Data_To_All_Tables
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RepositoryPatternWithUOW.Entities.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Bio")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Surname")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Bio = "Experienced software engineer with a passion for building scalable and efficient applications.",
                            Name = "John",
                            Surname = "Doe"
                        },
                        new
                        {
                            Id = 2,
                            Bio = "Author of best-selling programming books and contributor to open-source projects.",
                            Name = "Jane",
                            Surname = "Smith"
                        },
                        new
                        {
                            Id = 3,
                            Bio = "Front-end developer with expertise in creating intuitive and responsive user interfaces.",
                            Name = "Alex",
                            Surname = "Johnson"
                        },
                        new
                        {
                            Id = 4,
                            Bio = "Data scientist specializing in machine learning and predictive analytics.",
                            Name = "Eva",
                            Surname = "Brown"
                        },
                        new
                        {
                            Id = 5,
                            Bio = "Full-stack developer with a focus on creating robust and secure web applications.",
                            Name = "Michael",
                            Surname = "White"
                        },
                        new
                        {
                            Id = 6,
                            Bio = "Backend developer specializing in designing and optimizing database systems.",
                            Name = "Sarah",
                            Surname = "Lopez"
                        },
                        new
                        {
                            Id = 7,
                            Bio = "DevOps engineer automating deployment processes for efficient and reliable software delivery.",
                            Name = "Chris",
                            Surname = "Garcia"
                        },
                        new
                        {
                            Id = 8,
                            Bio = "Cybersecurity expert committed to ensuring the integrity and security of digital systems.",
                            Name = "Emily",
                            Surname = "Miller"
                        },
                        new
                        {
                            Id = 9,
                            Bio = "Mobile app developer creating innovative and user-friendly applications for iOS and Android.",
                            Name = "David",
                            Surname = "Wang"
                        },
                        new
                        {
                            Id = 10,
                            Bio = "UI/UX designer passionate about creating visually appealing and intuitive user interfaces.",
                            Name = "Rachel",
                            Surname = "Chen"
                        },
                        new
                        {
                            Id = 11,
                            Bio = "Software architect with over 15 years of experience in designing scalable and maintainable systems. Published author and conference speaker.",
                            Name = "Aiden",
                            Surname = "Williams"
                        },
                        new
                        {
                            Id = 12,
                            Bio = "Machine learning researcher and data scientist. Contributed to cutting-edge research projects in natural language processing and computer vision.",
                            Name = "Olivia",
                            Surname = "Martinez"
                        },
                        new
                        {
                            Id = 13,
                            Bio = "Front-end wizard crafting delightful and responsive user interfaces. Open-source contributor and advocate for web accessibility.",
                            Name = "Lucas",
                            Surname = "Taylor"
                        },
                        new
                        {
                            Id = 14,
                            Bio = "Blockchain developer and smart contract specialist. Enthusiastic about decentralized applications and the future of finance.",
                            Name = "Sophia",
                            Surname = "Lee"
                        },
                        new
                        {
                            Id = 15,
                            Bio = "Embedded systems engineer working on IoT solutions. Passionate about the intersection of hardware and software.",
                            Name = "Jackson",
                            Surname = "Nguyen"
                        },
                        new
                        {
                            Id = 16,
                            Bio = "Software developer with a focus on building scalable and maintainable backend systems. Enjoys solving complex problems and mentoring junior developers.",
                            Name = "Joseph",
                            Surname = "Albari"
                        },
                        new
                        {
                            Id = 17,
                            Bio = "Robert C. Martin, also known as Uncle Bob, is a software engineer and author. He is a key figure in the development of Agile methodologies and a proponent of clean code principles.",
                            Name = "Uncle",
                            Surname = "Bob"
                        });
                });

            modelBuilder.Entity("RepositoryPatternWithUOW.Entities.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Isbn")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("PublishedOn")
                        .HasColumnType("datetime");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 1,
                            CategoryId = 1,
                            Description = "A comprehensive guide to software development and best coding practices.",
                            Isbn = "978-1234567890",
                            Price = 29.99m,
                            PublishedOn = new DateTime(2022, 1, 15, 0, 0, 0, 0, DateTimeKind.Utc),
                            Title = "The Art of Coding"
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 2,
                            CategoryId = 5,
                            Description = "Explore the fundamentals of data science and its applications.",
                            Isbn = "978-0987654321",
                            Price = 39.99m,
                            PublishedOn = new DateTime(2021, 9, 20, 0, 0, 0, 0, DateTimeKind.Utc),
                            Title = "Data Science Essentials"
                        },
                        new
                        {
                            Id = 3,
                            AuthorId = 3,
                            CategoryId = 3,
                            Description = "Learn advanced techniques for creating modern and responsive user interfaces.",
                            Isbn = "978-9876543210",
                            Price = 34.99m,
                            PublishedOn = new DateTime(2021, 11, 30, 0, 0, 0, 0, DateTimeKind.Utc),
                            Title = "Mastering Front-End Development"
                        },
                        new
                        {
                            Id = 4,
                            AuthorId = 4,
                            CategoryId = 8,
                            Description = "Discover the transformative potential of blockchain technology.",
                            Isbn = "978-1357902468",
                            Price = 44.99m,
                            PublishedOn = new DateTime(2022, 3, 10, 0, 0, 0, 0, DateTimeKind.Utc),
                            Title = "Blockchain Revolution"
                        },
                        new
                        {
                            Id = 5,
                            AuthorId = 5,
                            CategoryId = 7,
                            Description = "A practical guide to securing web applications against cyber threats.",
                            Isbn = "978-5678901234",
                            Price = 32.99m,
                            PublishedOn = new DateTime(2022, 5, 25, 0, 0, 0, 0, DateTimeKind.Utc),
                            Title = "Web Security Handbook"
                        },
                        new
                        {
                            Id = 6,
                            AuthorId = 9,
                            CategoryId = 6,
                            Description = "Build cross-platform mobile apps using the Flutter framework.",
                            Isbn = "978-0123456789",
                            Price = 37.99m,
                            PublishedOn = new DateTime(2022, 2, 5, 0, 0, 0, 0, DateTimeKind.Utc),
                            Title = "Mobile App Development with Flutter"
                        },
                        new
                        {
                            Id = 7,
                            AuthorId = 12,
                            CategoryId = 4,
                            Description = "Apply artificial intelligence and machine learning techniques to real-world problems.",
                            Isbn = "978-5432109876",
                            Price = 49.99m,
                            PublishedOn = new DateTime(2021, 12, 18, 0, 0, 0, 0, DateTimeKind.Utc),
                            Title = "AI and Machine Learning in Practice"
                        },
                        new
                        {
                            Id = 8,
                            AuthorId = 17,
                            CategoryId = 1,
                            Description = "Explore the principles and practices of writing clean and maintainable code.",
                            Isbn = "978-8765432109",
                            Price = 42.99m,
                            PublishedOn = new DateTime(2021, 10, 8, 0, 0, 0, 0, DateTimeKind.Utc),
                            Title = "Clean Code A Handbook of Agile Software Craftsmanship"
                        },
                        new
                        {
                            Id = 9,
                            AuthorId = 15,
                            CategoryId = 10,
                            Description = "A comprehensive guide to designing embedded systems for various applications.",
                            Isbn = "978-1928374650",
                            Price = 36.99m,
                            PublishedOn = new DateTime(2022, 4, 12, 0, 0, 0, 0, DateTimeKind.Utc),
                            Title = "Embedded Systems Design"
                        },
                        new
                        {
                            Id = 10,
                            AuthorId = 10,
                            CategoryId = 9,
                            Description = "Learn the essential principles of user experience design for creating intuitive and user-friendly products.",
                            Isbn = "978-7654321098",
                            Price = 31.99m,
                            PublishedOn = new DateTime(2022, 6, 28, 0, 0, 0, 0, DateTimeKind.Utc),
                            Title = "UX Design Principles"
                        },
                        new
                        {
                            Id = 11,
                            AuthorId = 8,
                            CategoryId = 7,
                            Description = "An introductory guide to essential concepts in cybersecurity and online privacy.",
                            Isbn = "978-9876543211",
                            Price = 28.99m,
                            PublishedOn = new DateTime(2021, 8, 15, 0, 0, 0, 0, DateTimeKind.Utc),
                            Title = "Cybersecurity Fundamentals"
                        },
                        new
                        {
                            Id = 12,
                            AuthorId = 11,
                            CategoryId = 2,
                            Description = "Explore the practical aspects of cloud computing and its applications in modern IT environments.",
                            Isbn = "978-8765432101",
                            Price = 45.99m,
                            PublishedOn = new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Utc),
                            Title = "Cloud Computing: A Practical Approach"
                        },
                        new
                        {
                            Id = 13,
                            AuthorId = 6,
                            CategoryId = 3,
                            Description = "Learn the fundamentals of game development and create your own interactive experiences.",
                            Isbn = "978-5678901235",
                            Price = 39.99m,
                            PublishedOn = new DateTime(2022, 3, 28, 0, 0, 0, 0, DateTimeKind.Utc),
                            Title = "Game Development Essentials"
                        },
                        new
                        {
                            Id = 14,
                            AuthorId = 2,
                            CategoryId = 5,
                            Description = "Master the use of Python for data analysis, visualization, and machine learning.",
                            Isbn = "978-5432109877",
                            Price = 36.99m,
                            PublishedOn = new DateTime(2022, 1, 5, 0, 0, 0, 0, DateTimeKind.Utc),
                            Title = "Python for Data Analysis"
                        },
                        new
                        {
                            Id = 15,
                            AuthorId = 7,
                            CategoryId = 6,
                            Description = "A comprehensive guide to implementing DevOps practices for faster and more reliable software delivery.",
                            Isbn = "978-0123456788",
                            Price = 42.99m,
                            PublishedOn = new DateTime(2021, 10, 20, 0, 0, 0, 0, DateTimeKind.Utc),
                            Title = "DevOps Handbook"
                        });
                });

            modelBuilder.Entity("RepositoryPatternWithUOW.Entities.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Books covering various programming languages, software development methodologies, and coding practices.",
                            Name = "Programming"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Explore the practical aspects of cloud computing and its applications in modern IT environments.",
                            Name = "Cloud Computing"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Books focusing on front-end and back-end development, covering web technologies and frameworks.",
                            Name = "Web Development"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Discover the world of artificial intelligence, including machine learning, neural networks, and AI applications.",
                            Name = "Artificial Intelligence"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Essential guides for mastering data science concepts, analytics, and machine learning algorithms.",
                            Name = "Data Science"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Books on developing mobile applications, exploring frameworks, and best practices for iOS and Android.",
                            Name = "Mobile Development"
                        },
                        new
                        {
                            Id = 7,
                            Description = "Learn about cybersecurity fundamentals, threats, and countermeasures to protect digital assets.",
                            Name = "Cybersecurity"
                        },
                        new
                        {
                            Id = 8,
                            Description = "Explore the transformative potential of blockchain technology and its applications in various industries.",
                            Name = "Blockchain"
                        },
                        new
                        {
                            Id = 9,
                            Description = "Books focusing on user experience (UX) and user interface (UI) design principles for creating intuitive products.",
                            Name = "UX/UI Design"
                        },
                        new
                        {
                            Id = 10,
                            Description = "Comprehensive guides on designing embedded systems for various applications, including IoT solutions.",
                            Name = "Embedded Systems"
                        });
                });

            modelBuilder.Entity("RepositoryPatternWithUOW.Entities.Models.Book", b =>
                {
                    b.HasOne("RepositoryPatternWithUOW.Entities.Models.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Author_Book");

                    b.HasOne("RepositoryPatternWithUOW.Entities.Models.Category", "Category")
                        .WithMany("Books")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Category_Book");

                    b.Navigation("Author");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("RepositoryPatternWithUOW.Entities.Models.Author", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("RepositoryPatternWithUOW.Entities.Models.Category", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
