## 목차
- A. 메서드  
[A-1. 메서드](#a-1-메서드)  
[A-2. 정적(static) 메서드](#a-2-정적(static)-메서드)  
[A-3. 오버로딩](#a-3-오버로딩)  
[A-4. 접근제한자](#a-4-접근제한자자)  
[A-5. 상수(const)](#a-5-상수(const))  
[A-6. 속성](#a-6-속성)
  
- B. 상속  
[B-1. 상속](#B-1-상속)  
[B-2. base 키워드](#b-2-base-키워드)  
[B-3. is 키워드](#b-3-is-키워드)  
[B-4. as 키워드](#b-4-as-키워드)  
[B-5. 상속의 생성자](#b-5-상속의-생성자)  
[B-6. 섀도잉과 하이딩](#b-6-섀도잉과-하이딩)  
[B-7. 하이딩과 오버라이딩](#b-7-하이딩과-오버라이딩)  
[B-8. 상속과 오버라이딩 제한](#b-8-상속과-오버라이딩-제한)  
[B-9. enum 자료형(열거자)](#b-9-enum-자료형(열거자))  

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
## A-3. 오버로딩
: 이름은 갖고, 매개변수는 다른 메서드를 만드는 것
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
public Department(string code, string name) { //매개변수 생성자
    Code = code;
    Name = name;
}
```
```
//FormManager.cs
public FormManager() { //기본 생성자
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
  
## B-1. 상속  
base class : parent, super  
derived class : child, sub  
### 상속
```
class Animal {
  public int Age { get; set; }
  public Animal() { this.Age = 0; }

  public void Eat() { Console.WriteLine("냠냠"); }
  public void Sleep() { Console.WriteLine("쿨쿨"); }
}
```
```
class Dog : Animal {
  public string Color { get; set; }
  public void Bark() { Console.WriteLine("왈왈 짖습니다."); }
}
```

## B-2. base 키워드
자식 클래스에서 부모 클래스에서 정의한 Member 클래스를 사용하고 싶을 때  
부모 클래스(Member)의 생성자를 호출해 부모의 필드를 초기화
```
public Professor(string number, string name, Department dept) : base(number, name, dept)
```

## B-3. is 키워드
특정한 클래스가 어떤 클래스인지 확인하기 위해 사용
```
if (lbxDepartment.SelectedItem is Department) { //리스트박스에서 선택된 항목이 Department 타입인지 확인함(true, false)
    var target = (Department)lbxDepartment.SelectedItem; //맞다면 안전하게 Department 타입으로 캐스팅하여 사용함
    // ...
}
```
```
bool isDog = item is Dog dog;
if(isDog == true)
  dog.Bark();
```
## B-4. as 키워드
객체를 특정 타입으로 변환하려고 시도  
변환이 성공하면 변환된 객체를 반환하고, 실패하면 null 반
```
var department = cmbProfessorDepartment.SelectedItem as Department; //cmbProfessorDepartment.SelectedItem은 Object타입
if (department != null) {
    foreach (var professor in professors) {
        if (professor != null && professor.Dept.Code == department.Code) {
            lbxProfessor.Items.Add(professor);
        }
    }
}
```
## B-5. 상속의 생성자
```
class Program {
  class Parent {
    public Parent() { Console.WriteLine("Parent()"); }
    public Parent(int param) { Console.WriteLine("Parent(int param)"); }
    public Parent(string param) { Console.WriteLine("Parent(string param)"); }
}

class Child : Parent {
    public Child() : base(10) { //Parent(int param) 부모 생성자 호출
      Console.WriteLine("Child() : base(10)");
    }

    public Child() : base(input) { //Parent(string param) 부모 생성자 호출
      Console.WriteLine("Child(string input) : base(input)");
    }
}

static void Main(string[] args) {
  Child childA = new Child();
  Child childB = new Child("string");
}
```
```
//출력값
Parent(int param)
Child() : base(10)
Parent(string param)
Child(string input) : base(input)
```

## B-6. 섀도잉과 하이딩
### 섀도잉
특정한 영역에서 이름이 겹쳐서 다른 변수를 가리는 것

### 하이딩
부모 클래스의 멤버(변수, 메서드 등)와 같은 이름의 멤버를 자식 클래스에서 다시 선언하여, 부모의 멤버를 가리는 것
```
class Program {
    class Parent {
        public int variable = 273;
    }
    
    class Child : Parent {
        public string variable = "shadowing";
    }
    
    static void Main(string[] args) {
        Child child = new Child();
        Console.WriteLine(child.variable);
    }
}
```

## B-7. 하이딩과 오버라이딩
```
public new void Method() { Console.WriteLine("자식의 메서드"); } //하이딩 : 부모것을 숨김(기본)
public override void Method() { Console.WriteLine("자식의 메서드"); } //오버라이딩 : 부모것을 없앰
```
하이딩은 멤버 변수 전체(변수, 메서드 등)에서 모두 일어나지만, 오버라이딩은 메서드와 관련되어서만 일어남

### new 메서드
부모 클래스의 멤버와 자식 클래스의 멤버가 서로 이름이 같으면 하이딩되며,  
하이딩한다는 것을 명확하게 표시하고자 메서드 이름 앞에 new 키워드를 붙여줌

### virtual과 override 메서드
#### virtual : 가상 메서드
```
class Program {
    class Parent {
        public virtual void Method() {
            Console.WriteLine("부모의 메서드");
        }
    }
    
    class Child : Parent {
        public override void Method() {
            Console.WriteLine("자식의 메서드");
        }
    }
    
    static void Main(string[] args) {
        Child child = new Child();
        child.Method();
        ((Parent)child).Method(); //오버라이딩하면 클래스형을 어떻게 변환해도 자식에서 다시 정의한 메서드를 호출함
    }
}
```
```
//출력값
자식의 메서드
자식의 메서드
```

## B-8. 상속과 오버라이딩 제한
### sealed 키워드
클래스 : 상속하지 마라!  
메서드 : 더 이상 오버라이딩 하지 마라!

### abstract 키워드
클래스 : 무조건 상속해서 써라!  
메서드 : 무조건 오버라이딩 해라!
```
namespace Week09Homework
{
    abstract class Member
    {
        public string Number { get; protected set; }
        public string Name { get; protected set; }
        public Department Dept { get; set; }

        public Member(string number, string name, Department dept)
        {
            this.Number = number;
            this.Name = name;
            this.Dept = dept;
        }
    }
}
```

### abstract와 virtual의 차이
- abtract
  추상 메서드/프로퍼티를 선언할 때 사용  
  구현이 없음 > 이름, 반환형, 매개변수만 있고 실제 동작 x  
  반드시 추상 클래스에서만 선언 까능  
  상속받는 모든 자식 클래스에서 반드시 override로 구현해야 함
```
public abstract class Shape //abstract 클래스
{
    public abstract double Area(); // 구현 없음
}

public class Circle : Shape
{
    public override double Area() { return Math.PI * r * r; } // 반드시 구현해야 함
}
```  

- virtual
  가상 메서드/프로퍼티를 선언할 때 사용  
  기본 구현이 있음  
  자식 클래스에서 필요에 따라 override로 재정의할 수도 있고, 안해도 상관 없음  
  자식 클래스가 별도의 (추가) 동작이 필요하면 override하고, 필요 없으면 부모의 기본 구현을 그대로 사용할 수 있음  
  추상 클래스, 일반 클래스에서도 선언 가능
```
public class Vehicle //일반 클래스
{
    public virtual void Start()
    {
        Console.WriteLine("Starting the vehicle");
    }
}

public class Car : Vehicle
{
    public override void Start()
    {
        Console.WriteLine("Starting the car");
    }
}

public class Bicycle : Vehicle
{
    // override하지 않으면 Vehicle의 Start()가 그대로 사용됨
}
```

## B-9. enum 자료형(열거자)
```
enum YEAR
{
    ONE = 0,
    TWO,
    THREE,
    FOUR,
    END,
}
```
```
//FormManager.cs
for (int i = 0; i < (int)YEAR.END; i++) {
    cmbYear.Items.Add(Student.YearName[(YEAR)i]);
}
cmbClass.Items.AddRange(new object[] { CLASS.A, CLASS.B, CLASS.C });
//AddRange : 여러 개의 항목(컬렉션, 배열 등)을 한 번에 추가할 때 사용
//cmbClass 콤보박스의 항목 목록에 CLASS.A, CLASS.B, CLASS.C 를 한 번에 추가함

for (int i = 0; i < (int)REG_STATUS.END; i++) {
    cmbRegStatus.Items.Add(Student.RegStatusName[(REG_STATUS)i]);
    //Add는 하나의 항목만 추가
}
```
```
//Add와 AddRange 차이
List<int> numbers = new List<int>();
numbers.Add(1);
numbers.AddRange(new int[] {2, 3, 4});
```
