Public NotInheritable Class clsUser

    Private mUserID As String
    Private mUsername As String
    Private mFullname As String
    Private mnu_user As Integer
    Private mnu_employee_info As Integer
    Private mnu_schedules As Integer
    Private mnu_cutoff_periods As Integer
    Private mnu_assign_schedules As Integer
    Private mnu_generate_dtr As Integer
    Private mnu_dtr_adjustments As Integer
    Private mnu_print_dtr As Integer

    Public Property UserID() As String
        Get
            Return mUserID
        End Get
        Set(ByVal value As String)
            mUserID = value
        End Set
    End Property

    Public Property Username() As String
        Get
            Return mUsername
        End Get
        Set(ByVal value As String)
            mUsername = value
        End Set
    End Property

    Public Property Fullname() As String
        Get
            Return mFullname
        End Get
        Set(ByVal value As String)
            mFullname = value
        End Set
    End Property

    Public Property Menu_User() As Integer
        Get
            Return mnu_user
        End Get
        Set(ByVal value As Integer)
            mnu_user = value
        End Set
    End Property

    Public Property Menu_Employee_Info() As Integer
        Get
            Return mnu_employee_info
        End Get
        Set(ByVal value As Integer)
            mnu_employee_info = value
        End Set
    End Property

    Public Property Menu_Schedules() As Integer
        Get
            Return mnu_schedules
        End Get
        Set(ByVal value As Integer)
            mnu_schedules = value
        End Set
    End Property

    Public Property Menu_Cutoff_Periods() As Integer
        Get
            Return mnu_cutoff_periods
        End Get
        Set(ByVal value As Integer)
            mnu_cutoff_periods = value
        End Set
    End Property

    Public Property Menu_Assign_Schedules() As Integer
        Get
            Return mnu_assign_schedules
        End Get
        Set(ByVal value As Integer)
            mnu_assign_schedules = value
        End Set
    End Property

    Public Property Menu_Generate_DTR() As Integer
        Get
            Return mnu_generate_dtr
        End Get
        Set(ByVal value As Integer)
            mnu_generate_dtr = value
        End Set
    End Property

    Public Property Menu_DTR_Adjustments() As Integer
        Get
            Return mnu_dtr_adjustments
        End Get
        Set(ByVal value As Integer)
            mnu_dtr_adjustments = value
        End Set
    End Property

    Public Property Menu_Print_DTR() As Integer
        Get
            Return mnu_print_dtr
        End Get
        Set(ByVal value As Integer)
            mnu_print_dtr = value
        End Set
    End Property
End Class
