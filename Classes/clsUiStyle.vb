Public Class clsUiStyle

    Public Shared Event UiStyleChanged()

    Private _UiStyle As UiStyles

    Private _MainMenuBackgroundColor As System.Drawing.Color
    Private _DarkBackgroundColor As System.Drawing.Color
    Private _LightBackgroundColor As System.Drawing.Color
    Private _ButtonSelectedColor As System.Drawing.Color
    Private _ActionButtonBorderColor As System.Drawing.Color
    Private _CheckedImage As Image
    Private _SelectedOption As Image

    Public Enum UiStyles
        eShop = 0
        Sf3 = 1
    End Enum

    Public ReadOnly Property MainMenuBackgroundColor() As System.Drawing.Color

        Get
            MainMenuBackgroundColor = _MainMenuBackgroundColor
        End Get

    End Property

    Public ReadOnly Property DarkBackgroundColor() As System.Drawing.Color

        Get
            DarkBackgroundColor = _DarkBackgroundColor
        End Get

    End Property

    Public ReadOnly Property LightBackgroundColor() As System.Drawing.Color

        Get
            LightBackgroundColor = _LightBackgroundColor
        End Get

    End Property

    Public ReadOnly Property ButtonSelectedColor() As System.Drawing.Color

        Get
            ButtonSelectedColor = _ButtonSelectedColor
        End Get

    End Property

    Public ReadOnly Property ActionButtonBorderColor() As System.Drawing.Color

        Get
            ActionButtonBorderColor = _ActionButtonBorderColor
        End Get

    End Property

    Public ReadOnly Property CheckedImage() As Image

        Get
            CheckedImage = _CheckedImage
        End Get

    End Property

    Public ReadOnly Property SelectedOption() As Image

        Get
            SelectedOption = _SelectedOption
        End Get

    End Property

    Public Property UiStyle() As UiStyles

        Get
            UiStyle = _UiStyle
        End Get
        Set(UiStyle As UiStyles)
            _UiStyle = UiStyle
            Select Case _UiStyle
                Case UiStyles.eShop
                    _MainMenuBackgroundColor = System.Drawing.ColorTranslator.FromHtml("#364860") ' Dark Blue
                    _LightBackgroundColor = System.Drawing.ColorTranslator.FromHtml("#358DCA") ' Light blue
                    _DarkBackgroundColor = System.Drawing.ColorTranslator.FromHtml("#364860") ' Dark Blue
                    _ButtonSelectedColor = System.Drawing.ColorTranslator.FromHtml("#358DCA") ' Light blue
                    _ActionButtonBorderColor = System.Drawing.ColorTranslator.FromHtml("#358DCA") ' Light blue
                    _CheckedImage = My.Resources.BlueCheckSelected
                    _SelectedOption = My.Resources.BlueOptionSelected

                Case UiStyles.Sf3
                    _MainMenuBackgroundColor = System.Drawing.ColorTranslator.FromHtml("#777777") ' Dark Grey
                    _LightBackgroundColor = System.Drawing.ColorTranslator.FromHtml("#777777") ' Dark Grey
                    _DarkBackgroundColor = System.Drawing.ColorTranslator.FromHtml("#C41E3A") ' SMS Red
                    _ButtonSelectedColor = System.Drawing.ColorTranslator.FromHtml("#C41E3A") ' SMS Red
                    _ActionButtonBorderColor = System.Drawing.ColorTranslator.FromHtml("#C41E3A") ' SMS Red
                    _CheckedImage = My.Resources.RedCheckSelected
                    _SelectedOption = My.Resources.RedOptionSelected

            End Select
            If IsInitialized Then
                RaiseEvent UiStyleChanged()
            End If
        End Set

    End Property

    Private Property IsInitialized = False

    Public Sub New()

        UiStyle = UiStyles.eShop
        Me.IsInitialized = True
    End Sub
End Class
