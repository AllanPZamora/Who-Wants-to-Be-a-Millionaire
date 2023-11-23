Imports System.Windows.Forms

Public Class Game
    Private currentQuestionIndex As Integer = 0
    Private questions As List(Of Question) = New List(Of Question)()
    Private answerButtons As List(Of Button)
    Private rand As New Random()

    Private Sub InitializeQuestions()
        questions.Add(New Question("What does 'IDE' stand for in programming?", {"Integrated Design Environment", "Integrated Development Environment", "Internet Development Engine", "Intelligent Debugging Environment"}, 1))
        questions.Add(New Question("Which of the following is a high-level programming language?", {"Binary", "Assembly", "C++", "Machine Code"}, 2))
        questions.Add(New Question("In programming, what is the purpose of a 'variable'?", {"It is used to create loops.", "It represents a value that can change", "It is a type of comment.", "It is used for printing text."}, 1))
        questions.Add(New Question("Which programming paradigm focuses on defining data structures and the methods that operate on them?", {"Object-Oriented Programming", "Functional Programming", "Procedural Programming", "Imperative Programming"}, 0))
        questions.Add(New Question("What is the primary function of a 'for loop' in programming?", {"To define classes", "To encapsulate data", "To iterate a specific number of times", "To perform calculations"}, 2))
        questions.Add(New Question("What does 'API' stand for in programming?", {"Automated Programming Interface", "Application Programming Interface", "Advanced Programming Instruction", "Automated Program Integration"}, 1))
        questions.Add(New Question("In programming, what is 'debugging'?", {"Adding new features to a program", "The process of identifying and fixing errors in code", "Documenting code", "Optimizing code for speed"}, 1))
        questions.Add(New Question("Which programming language is often used for web development on the client side?", {"C++", "Python", "JavaScript", "SQL"}, 2))
        questions.Add(New Question("What does 'OOP' stand for in programming?", {"Object-Oriented Programming", "Object-Oriented Protocol", "Open-Source Project", "Object-Oriented Procedure"}, 0))
        questions.Add(New Question("What is a 'Boolean' in programming?", {"A data type that represents true or false values", "A type of loop", "A specific error message", "A way to hide code from others"}, 0))
        questions.Add(New Question("What is the purpose of a 'while loop' in programming?", {"To define classes", "To encapsulate data", "To perform a specific action repeatedly while a condition is true", "To display messages to the user"}, 2))
        questions.Add(New Question("What is 'algorithm' in programming?", {"A mathematical equation", "A step-by-step procedure for solving a specific problem or performing a task", "A type of programming language", "A programming error message"}, 1))
        questions.Add(New Question("What is the purpose of 'conditional statements' in programming?", {"They are used for adding comments to code", "They allow you to make decisions in your code based on certain conditions", "They represent different data types", "They help with code formatting"}, 1))
        questions.Add(New Question("What is the purpose of 'comments' in programming code?", {"To execute code", "To prevent code from running", "To provide explanations or notes within the code for documentation and readability", "To create user interfaces"}, 2))
        questions.Add(New Question("In programming, what is a 'stack' and a 'queue'?", {"Data types", "Data structures used for storing and accessing elements in a specific order", "Functions for drawing graphics", "Networking protocols"}, 1))
        questions.Add(New Question("Who is considered the world's first computer programmer?", {"Charles Babbage", "Alan Turing", "Ada Lovelace", "Grace Hopper"}, 2))
        questions.Add(New Question("What machine was Ada Lovelace working on with Charles Babbage when she wrote the first computer program?", {"ENIAC", "UNIVAC", "Analytical Engine", "Difference Engine"}, 2))
        questions.Add(New Question("In which year did Ada Lovelace write her notes and programs for the Analytical Engine?", {"1812", "1837", "1843", "1865"}, 2))
        questions.Add(New Question("Who designed the first mechanical computer, known as the Analytical Engine?", {"Alan Turing", "John von Neumann", "Charles Babbage", "Ada Lovelace"}, 2))
        questions.Add(New Question("When was the first functioning model of the Analytical Engine built?", {"It was never built during Babbage's lifetime", "1940s", "1960s", "2002"}, 0))
        questions.Add(New Question("Who was Charles Babbage?", {"A famous painter", "A renowned mathematician and inventor", "A famous actor", "A medieval historian"}, 1))
        questions.Add(New Question("Which of the following is a high-level programming language?", {"Binary", "Assembly", "C++", "All of the above"}, 2))
        questions.Add(New Question("What is a data structure?", {"A way to structure code in a program", "A way to structure data for storage and efficient access", "A type of programming language", "A data visualization tool"}, 1))
        questions.Add(New Question("Which of the following is not a commonly used data structure in programming?", {"Arrays", "Trees", "Algorithms", "Stacks"}, 2))
        questions.Add(New Question("Who developed Visual Basic?", {"Microsoft", "IBM", "Apple", "Oracle"}, 0))
        questions.Add(New Question("What is Visual Basic?", {"A web browser", "A visual design tool for creating user interfaces", "A programming language and integrated development environment (IDE)", "A type of computer monitor"}, 2))
        questions.Add(New Question("Who developed JavaScript?", {"Microsoft", "Sun Microsystems", "Netscape", "IBM"}, 2))
        questions.Add(New Question("What is JavaScript?", {"A type of coffee", "A markup language", "A high-level, interpreted programming language for web development", "A document format"}, 2))
        questions.Add(New Question("Who originally developed Java?", {"Apple", "IBM", "Microsoft", "Sun Microsystems"}, 3))
        questions.Add(New Question("What does 'JRE' stand for in Java?", {"Java Runtime Engine", "Java Runtime Environment", "Java Running Emulator", "Java Resource Editor"}, 1))
    End Sub

    Private Sub Game_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeQuestions()
        ShuffleQuestions()
        InitializeAnswerButtons()
        DisplayQuestion()
    End Sub

    Private Sub ShuffleQuestions()
        Dim shuffledQuestions As List(Of Question) = questions.OrderBy(Function() rand.Next()).ToList()
        questions = shuffledQuestions
    End Sub

    Private Sub InitializeAnswerButtons()
        answerButtons = New List(Of Button) From {btnAnswer1, btnAnswer2, btnAnswer3, btnAnswer4}
    End Sub

    Private Sub DisplayQuestion()
        If currentQuestionIndex < questions.Count Then
            Dim currentQuestion As Question = questions(currentQuestionIndex)
            TextBox1.Text = currentQuestion.Text

            If answerButtons IsNot Nothing Then
                For i As Integer = 0 To currentQuestion.Answers.Length - 1
                    If i < answerButtons.Count Then
                        answerButtons(i).Text = currentQuestion.Answers(i)
                    End If
                Next
            End If
        End If
    End Sub

    Private Sub CloseGame()
        Me.Close()
    End Sub

    Private Const CorrectAnswersToWin As Integer = 25
    Private Sub CheckAnswer(selectedIndex As Integer)
        Dim currentQuestion As Question = questions(currentQuestionIndex)
        Dim grade As Integer = Convert.ToInt32(ListBox1.SelectedItem)
        If currentQuestion.CorrectAnswerIndex = selectedIndex Then

            If currentQuestionIndex < ListBox1.Items.Count Then
                ListBox1.SelectedIndex = ListBox1.Items.Count - currentQuestionIndex - 1
                MessageBox.Show($"Congratulations! Your grade is now {grade}.")
            End If

            If currentQuestionIndex = 24 Then
                MessageBox.Show("Congratulations! You've Reached 100. You've completed the game!")
                GameOver.Label1.Text = $"Congratulations! Your grade is {grade}."
                CloseGame()
            End If

            If CheckWinCondition() Then
                MessageBox.Show($"Congratulations! Your grade is now {grade}.")
                GameOver.Label1.Text = $"Congratulations! Your grade is {grade}."
                GameOver.Show()
                CloseGame()
            End If
        Else
            If currentQuestionIndex < ListBox1.Items.Count Then
                MessageBox.Show($"Incorrect! Game Over. Your final grade is {grade}.")
                GameOver.Label1.Text = $"Congratulations! Your grade is {grade}."
                GameOver.Show()
                CloseGame()
            End If
        End If

        currentQuestionIndex += 1
        DisplayQuestion()
    End Sub

    Private Function CheckWinCondition() As Boolean
        Dim correctAnswersCount As Integer = 0

        For i As Integer = 0 To currentQuestionIndex
            If questions(i).CorrectAnswerIndex = i Then
                correctAnswersCount += 1
            Else
                correctAnswersCount = 0
            End If

            If correctAnswersCount = CorrectAnswersToWin Then
                Return True
            End If
        Next

        Return False
    End Function

    Private Sub btnAnswer1_Click(sender As Object, e As EventArgs) Handles btnAnswer1.Click
        CheckAnswer(0)
    End Sub

    Private Sub btnAnswer2_Click(sender As Object, e As EventArgs) Handles btnAnswer2.Click
        CheckAnswer(1)
    End Sub

    Private Sub btnAnswer3_Click(sender As Object, e As EventArgs) Handles btnAnswer3.Click
        CheckAnswer(2)
    End Sub

    Private Sub btnAnswer4_Click(sender As Object, e As EventArgs) Handles btnAnswer4.Click
        CheckAnswer(3)
    End Sub

    Private Sub Btn5050_Click(sender As Object, e As EventArgs) Handles Btn5050.Click

    End Sub

    Private Sub BtnIns_Click(sender As Object, e As EventArgs) Handles BtnIns.Click

    End Sub

    Private Sub BtnSkip_Click(sender As Object, e As EventArgs) Handles BtnSkip.Click

    End Sub
End Class

Public Class Question
    Public Property Text As String
    Public Property Answers As String()
    Public Property CorrectAnswerIndex As Integer

    Public Sub New(questionText As String, answerOptions As String(), correctIndex As Integer)
        Text = questionText
        Answers = answerOptions
        CorrectAnswerIndex = correctIndex
    End Sub
End Class