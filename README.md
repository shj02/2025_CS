# 목차
- A. 메서드  
[A-1. 메서드](#A-1.-메서드)  
[A-2. 정적(static) 메서드](A-2.-정적-static--메서드)

## A-1. 메서드
\[접근 제한자\] (static) \[반환형\] \[메서드 이름\](매개변수)  

### 반환타입 void : 아무것도 반환하지 않음
```
private void SetCode(string value)
{
    if (false == string.IsNullOrEmpty(value)) {
        _code = value; //value값을 받아서 _code에 저장만 하고 반환 x
    }
}

public void Print() //매개변수 없어도 되는 경우
{    Colsole.WriteLine(“Print() 메서드 호출”);
}
```
---
## A-2. 정적(static) 메서드  
: 클래스의 인스턴스를 생성하지 않고 클래스 이름으로 직접 호출  
객체를 만들지 않고도 사용 가능
```
Class MyClass {
  public int InstanceValue = 10;

  public int InstanceMethod() {
    return InstanceValue;
  }

public static int StaticMethod() {
  return 100;
}

//호출
MyClass obj = new MyClass();
int a = obj.InstanceMethod(); //인스턴스 메서드 호출(객체 a 필요)
int b = MyClass.StaticMethod(); //정적 메서드 호출 (객체 불필요)
```
```
//Department.cs
public static Department Restore(string record) {...}

//FormManager.cs
var dept = Department.Restore(data); //클래스명.메서드명() 형태로 호출
```
> public static : 어디서나 클래스명.메서드명()으로 호출 가능  
> private static : 선언한 클래스 내부에서만 호출 가능
---
## A-3. 오버로딩 : 이름은 갖고, 매개변수는 다른 메서드를 만드는 것
> overriding이랑은 완전 다름!
```
private void OpenInfo(ref Department[] departments, string filename) {...}
private void OpenInfo(ref List<Professor> professors, string filename) {...}
private void OpenInfo(out Dictionary<string, Student> student, string filename) {...}
```
> 매개변수가 달라야하며, 반환값이 다르면 오버로딩 X

## A-4. 접근 제한자  
### private  
+ 접근 제한자를 입력하지 않으면 자동으로 private 설정(클래스 예외 > internal)
+ 자신의 클래스 내부에서만 사용 가능

### public
+ 모든 곳에 접근 가능

### protected
+ 외부에서 값을 변경할 수 없지만 **상속** 받은 자식 클래스에서는 값을 변경할 수 있음

### internal
+ 동일 어셈블리(프로젝트) 내에서만 접근 가능하게 함
+ 라이브러리나 대형 프로젝트에서, 외부에는 공개하지 않고 내부적으로만 사용하고 싶은 타입/멤버에 주로 사용
---
### 생성자
+ 인스턴스를 생성할 때 자동으로 호출하는 메서드
+ 이름은 클래스 이름과 같아야 함
+ 반환과 관련된 선언을 하지 않음 > public \[클래스 이름\](\[매개변수\]) {...}
+ 접근 제한자 public(꼭 그럴 필요는 x)
+ 일반적으로 인스턴스 변수를 초기화하는 일을 함
```
//Department.cs
public Department(string code, string name) {
    Code = code;
    Name = name;
}
```
```
//FormManager.cs
public FormManager() {
    InitializeComponent();

    departments = new Department[100];
    professors = new List<Professor>();
    students = new Dictionary<string, Student>();
    //...
}

Department dept = new Department("A001", "컴퓨터정보"); //생성자에서 code, name, 초기화
Professor prof = new Professor("P001", "홍길동, dept);
Student stu = new Student("20240001", "이순신");
```
### 종료자(Finalizer)
+ 인스턴스가 소멸될 때 호출
```
Class Product() {
    public string name;
    public int price;

    public Product(string name, int price) {
        this.name = name;
        this.price = price;
    }

    ~Product() {
        Console.WriteLine(this.name + "의 종료자(소멸자) 호출");
    }
}
```

## A-5. 상수(const)
+ 메서드 내 지역 변수에 사용 가능
+ 클래스 내에서 사용 가능(단, static 성격)
---

## A-6. 속성
### 게터와 세터
+ C#의 프로퍼티에서 사용하는 접근자
+ get : 값을 읽을 때, set : 값을 쓸 때
```
///Department.cs
private string _code;

public string Code {
    get { return _code; }
    private set {
        if (false == string.IsNullOrEmpty(value)) {
            _code = value;
        } else {
            throw new Exception("Value is Empty");
        }
    }
}

Department dept = new Department("A001", "컴퓨터정보");
string code = dept.Code;
```

자동구현 프로퍼티
```
public int Age { get; set;}
```
- 게터 세터 사용법
```
\[인스턴스 이름\].\[속성 이름\] //게터 호출
\[인스턴스 이름\].\[속성 이름\] = \[값\] //세터 호출
```
- C# 클래스 구성요소  
필드(변수)  
프로퍼티(함수+변수)  
메서드(함수)  
---
Department.cs
```
Department(string code, string name) {...}
```
여기서의 Department는 클래스명 -> Department 클래스의 생성자 > Department라는 타입의 객체를 만들 때 호출하는 메서드

FormManager.cs
```
Department[] departments;
```
여기서의 Department[]는 Department 클래스 타입의 객체들을 여러 개 담을 수 있는 배열을 의미  
departments는 Department 객체 여러 개를 저장하는 배열 변수

> Department 클래스는 하나의 학과 정보를 담는 객체 타입
> Department[]는 그 객체 여러 개를 담는 배열 타입
---
