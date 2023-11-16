Imports System.Windows.Forms

Public Class Game
    Private currentQuestionIndex As Integer = 0
    Private questions As List(Of Question) = New List(Of Question)()
    Private answerButtons As List(Of Button)


    Private Sub InitializeQuestions()
        questions.Add(New Question("What does 'IDE' stand for in programming?", {"Integrated Design Environment", "Integrated Development Environment", "Internet Development Engine", "Intelligent Debugging Environment"}, 1, 1000))
        questions.Add(New Question("Which of the following is a high-level programming language?", {"Binary", "Assembly", "C++", "Machine Code"}, 2, 1000))
        questions.Add(New Question("In programming, what is the purpose of a 'variable'?", {"It is used to create loops.", "It represents a value that can change", "It is a type of comment.", "It is used for printing text."}, 1, 1000))
        questions.Add(New Question("Which programming paradigm focuses on defining data structures and the methods that operate on them?", {"Object-Oriented Programming", "Functional Programming", "Procedural Programming", "Imperative Programming"}, 0, 1000))
        questions.Add(New Question("What is the primary function of a 'for loop' in programming?", {"To define classes", "To encapsulate data", "To iterate a specific number of times", "To perform calculations"}, 2, 1000))
        questions.Add(New Question("What does 'API' stand for in programming?", {"Automated Programming Interface", "Application Programming Interface", "Advanced Programming Instruction", "Automated Program Integration"}, 1, 1000))
        questions.Add(New Question("In programming, what is 'debugging'?", {"Adding new features to a program", "The process of identifying and fixing errors in code", "Documenting code", "Optimizing code for speed"}, 1, 1000))
        questions.Add(New Question("Which programming language is often used for web development on the client side?", {"C++", "Python", "JavaScript", "SQL"}, 2, 1000))
        questions.Add(New Question("What does 'OOP' stand for in programming?", {"Object-Oriented Programming", "Object-Oriented Protocol", "Open-Source Project", "Object-Oriented Procedure"}, 0, 1000))
        questions.Add(New Question("What is a 'Boolean' in programming?", {"A data type that represents true or false values", "A type of loop", "A specific error message", "A way to hide code from others"}, 0, 1000))
        questions.Add(New Question("What is the purpose of a 'while loop' in programming?", {"To define classes", "To encapsulate data", "To perform a specific action repeatedly while a condition is true", "To display messages to the user"}, 2, 1000))
        questions.Add(New Question("What is 'algorithm' in programming?", {"A mathematical equation", "A step-by-step procedure for solving a specific problem or performing a task", "A type of programming language", "A programming error message"}, 1, 1000))
        questions.Add(New Question("What is the purpose of 'conditional statements' in programming?", {"They are used for adding comments to code", "They allow you to make decisions in your code based on certain conditions", "They represent different data types", "They help with code formatting"}, 1, 1000))
        questions.Add(New Question("What is the purpose of 'comments' in programming code?", {"To execute code", "To prevent code from running", "To provide explanations or notes within the code for documentation and readability", "To create user interfaces"}, 2, 1000))
        questions.Add(New Question("In programming, what is a 'stack' and a 'queue'?", {"Data types", "Data structures used for storing and accessing elements in a specific order", "Functions for drawing graphics", "Networking protocols"}, 1, 1000))
    End Sub

    Private Sub Game_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeQuestions()
        ShuffleQuestions()
        InitializeAnswerButtons()
        DisplayQuestion()
    End Sub

    Private Sub ShuffleQuestions()
        Dim rand As New Random()
        questions = questions.OrderBy(Function() rand.Next()).ToList()
    End Sub
    Private Sub InitializeAnswerButtons()
        answerButtons = New List(Of Button) From {btnAnswer1, btnAnswer2, btnAnswer3, btnAnswer4}
    End Sub
    Private Sub DisplayQuestion()
        If currentQuestionIndex < questions.Count Then
            Dim currentQuestion As Question = questions(currentQuestionIndex)
            TextBox1.Text = currentQuestion.Text

            For i As Integer = 0 To currentQuestion.Answers.Length - 1
                CType(Me.Controls("btnAnswer" & (i + 1)), Button).Text = currentQuestion.Answers(i)
            Next
        Else

            MessageBox.Show("Congratulations! You've answered all questions.")
            Me.Close()
        End If
    End Sub

    Private totalWinnings As Integer = 0

    Private Sub CheckAnswer(selectedIndex As Integer)
        Dim currentQuestion As Question = questions(currentQuestionIndex)

        If currentQuestion.CorrectAnswerIndex = selectedIndex Then
            MessageBox.Show("Correct! You've won $" & currentQuestion.Winnings & ".")
            totalWinnings += currentQuestion.Winnings
        Else
            MessageBox.Show("Incorrect! Game Over.")
            Me.Close()
            Main.Show()
        End If

        currentQuestionIndex += 1
        DisplayQuestion()
    End Sub

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
End Class

Public Class Question
    Public Property Text As String
    Public Property Answers As String()
    Public Property CorrectAnswerIndex As Integer
    Public Property Winnings As Integer

    Public Sub New(questionText As String, answerOptions As String(), correctIndex As Integer, winnings As Integer)
        Text = questionText
        Answers = answerOptions
        CorrectAnswerIndex = correctIndex
        Me.Winnings = winnings
    End Sub
End Class
