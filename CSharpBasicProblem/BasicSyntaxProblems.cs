using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace CSharpBasics
{
    /// <summary>
    /// C# 学習用の初級問題
    /// 
    /// </summary>
    public static class BasicSyntaxProblems
    {
        public static int Add(int a, int b)
        {
            // 問題 1: 変数と四則演算
            // 2つの整数 a と b を受け取り、その合計を返してください。
            return (a + b);
        }

        public static int Remainder(int dividend, int divisor)
        {
            // 問題 2: 剰余演算
            // dividend を divisor で割った余りを返してください。
            return dividend % divisor;
        }

        public static double CalculateCircleArea(double radius)
        {
            // 問題 3: double と定数
            // 半径 radius の円の面積を返してください。
            // 円周率には Math.PI を使ってください。
            return (radius * radius * Math.PI);
        }

        public static bool IsEven(int number)
        {
            // 問題 4: bool と条件判定
            // number が偶数なら true、奇数なら false を返してください。
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string GetGrade(int score)
        {
            // 問題 5: if / else if / else
            // score に応じて成績を返してください。
            // 90点以上は "A"、80点以上は "B"、70点以上は "C"、60点以上は "D"、それ未満は "F" を返します。
            // score が 0 未満または 100 より大きい場合は "Invalid" を返してください。
            if (0 <= score && score <= 100)
            {
                if (score >= 90)
                {
                    return "A";
                }
                else if (score >= 80)
                {
                    return "B";
                }
                else if (score >= 70)
                {
                    return "C";
                }
                else if (score >= 60)
                {
                    return "D";
                }
                else
                {
                    return "F";
                }
            }
            return "Invalid";
        }

        public static string GetDayName(int day)
        {
            // 問題 6: switch 式または switch 文
            // day が 1 なら "Monday"、2 なら "Tuesday"、3 なら "Wednesday"、
            // 4 なら "Thursday"、5 なら "Friday"、6 なら "Saturday"、7 なら "Sunday" を返してください。
            // 1 から 7 以外の場合は "Invalid" を返してください。

            switch (day)
            {
                case 1:
                    return "Monday";
                case 2:
                    return "Tuesday";
                case 3:
                    return "Wednesday";
                case 4:
                    return "Thursday";
                case 5:
                    return "Friday";
                case 6:
                    return "Saturday";
                case 7:
                    return "Sunday";
                default:
                    return "Invalid";
            }
        }

        public static int SumFromOneTo(int n)
        {
            // 問題 7: for ループ
            // 1 から n までの整数の合計を返してください。
            // n が 0 以下の場合は 0 を返してください。
            int sum = 0;
            if (n <= 0) return 0;
            for (int i = 0; i <= n; i++)
            {
                sum += i;
            }
            return sum;
        }

        public static int CountDownByWhile(int start)
        {
            // 問題 8: while ループ
            // start から 1 まで while 文でカウントした回数を返してください。
            // 例: start が 3 の場合、3, 2, 1 の3回なので 3 を返します。
            // start が 0 以下の場合は 0 を返してください。
            int count = 0;
            while (start >= 1)
            {
                count += 1;
                start -= 1;
            }
            return count;
        }

        public static int FindMax(int[] numbers)
        {
            // 問題 9: 配列
            // 整数配列 numbers の最大値を返してください。
            // numbers が空の場合は ArgumentException を投げてください。
            if (numbers.Length == 0) throw new ArgumentException();
            int max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            return max;
        }

        public static int CountPositiveNumbers(int[] numbers)
        {
            // 問題 10: foreach ループ
            // 整数配列 numbers の中にある正の数、つまり 1 以上の数の個数を返してください。
            int count = 0;
            foreach (int n in numbers)
            {
                if (n > 0)
                {
                    count++;
                }
            }
            return count;
        }

        public static List<int> DoubleEachNumber(List<int> numbers)
        {
            // 問題 11: List<T>
            // numbers の各要素を2倍にした新しい List<int> を返してください。
            // 引数の List 自体は変更しないでください。
            List<int> result = new List<int>();
            foreach (int n in numbers)
            {
                result.Add(n * 2);
            }
            return result;
        }

        public static string RepeatText(string text, int count)
        {
            // 問題 12: 文字列とループ
            // text を count 回連結した文字列を返してください。
            // count が 0 以下の場合は空文字列を返してください。
            string result = string.Empty;
            if (count <= 0) return result;
            for (int i = 1; i <= count; i++)
            {
                result += text;
            }
            return result;
        }

        public static string NormalizeName(string firstName, string lastName)
        {
            // 問題 13: 文字列メソッド
            // firstName と lastName の前後の空白を取り除き、"First Last" の形式で返してください。
            // 例: firstName が " Taro "、lastName が " Yamada " の場合は "Taro Yamada" を返します。
            return $"{firstName.Trim()} {lastName.Trim()}";
        }

        public static bool ContainsIgnoreCase(string source, string keyword)
        {
            // 問題 14: 大文字小文字を区別しない文字列検索
            // source の中に keyword が含まれていれば true、含まれていなければ false を返してください。
            // 大文字と小文字は区別しないでください。
            string upperSource = source.ToUpper();
            string upperKeyword = keyword.ToUpper();

            return upperSource.Contains(upperKeyword);
        }

        public static Dictionary<string, int> CountWords(IEnumerable<string> words)
        {
            // 問題 15: Dictionary<TKey, TValue>
            // words に含まれる各単語の出現回数を Dictionary<string, int> として返してください。
            // 例: ["apple", "banana", "apple"] の場合、"apple" は 2、"banana" は 1 です。
            Dictionary<string, int> result = new Dictionary<string, int>();
            foreach (string w in words)
            {
                if (!result.ContainsKey(w))
                {
                    result[w] = 1;
                }
                else
                {
                    result[w] += 1;
                }
            }
            return result;
        }

        public static double CalculateValidScoreAverage(int[] scores)
        {
            // 問題 16: 難易度 2 - 配列、条件分岐、平均値
            // scores のうち 0 以上 100 以下の値だけを有効な点数として扱い、その平均値を返してください。
            // 無効な点数は平均の計算から除外してください。
            // 有効な点数が1つもない場合は 0 を返してください。
            double sum = 0;
            int denominator = 0;
            foreach (int score in scores)
            {
                if (score < 0 || 100 < score) continue;
                sum += score;
                denominator += 1;
            }
            if (denominator != 0)
            {
                return sum / denominator;
            }
            return 0;
        }

        public static List<string> BuildFizzBuzz(int start, int end)
        {
            // 問題 17: 難易度 2 - ループと複数条件
            // start から end までの整数を順番に見て、次のルールで文字列の List を返してください。
            // 3 と 5 の両方で割り切れる数は "FizzBuzz"、3 で割り切れる数は "Fizz"、
            // 5 で割り切れる数は "Buzz"、それ以外は数値を文字列にしたものを入れてください。
            // start が end より大きい場合は空の List<string> を返してください。
            List<string> result = new List<string>();
            int i = start;
            if (i > end) return result;
            while (i <= end)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    result.Add("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    result.Add("Fizz");
                }
                else if (i % 5 == 0)
                {
                    result.Add("Buzz");
                }
                else
                {
                    result.Add(i.ToString());
                }
                i += 1;
            }
            return result;
        }

        public static int GetLongestWordLength(string sentence)
        {
            // 問題 18: 難易度 2 - 文字列とループ
            // sentence を半角スペースで区切ったとき、最も長い単語の文字数を返してください。
            // 連続したスペースや前後のスペースは単語として数えません。
            // 単語が1つもない場合は 0 を返してください。
            string[] words = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (words.Length == 0) return 0;

            int LongestWordsLength = 0;
            for (int i = 0; i <= words.Length - 1; i++)
            {
                if (words[i].Length > LongestWordsLength)
                {
                    LongestWordsLength = words[i].Length;
                }
            }

            return LongestWordsLength;
        }

        public static bool IsPalindromeIgnoreCaseAndSpaces(string text)
        {
            // 問題 19: 難易度 3 - 文字列の正規化と比較
            // text が回文なら true、そうでなければ false を返してください。
            // 大文字と小文字は区別せず、半角スペースは無視してください。
            // 例: "Never odd or even" はスペースと大文字小文字を無視すると回文なので true です。

            string normalized = text
                .Replace(" ", "")
                .ToUpper();

            for (int i = 0; i < normalized.Length / 2; i++)
            {

                if (normalized[i] != normalized[normalized.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }

        public static List<int> RotateLeft(List<int> numbers, int count)
        {
            // 問題 20: 難易度 3 - List<T> とインデックス
            // numbers の要素を左に count 個分回転させた新しい List<int> を返してください。
            // 例: [1, 2, 3, 4, 5] を左に 2 回転すると [3, 4, 5, 1, 2] です。
            // count が要素数より大きい場合も正しく回転してください。
            // numbers が空の場合は空の List<int> を返してください。
            // 引数の List 自体は変更しないでください。
            List<int> result = new List<int>(numbers.Count);

            if (numbers.Count == 0) return result;

            for (int i = 0; i < numbers.Count; i++)
            {
                result.Add(numbers[(i + count % numbers.Count) % numbers.Count]);
            }

            return result;
        }

        public static Dictionary<string, int> MergeWordCounts(
            Dictionary<string, int> first,
            Dictionary<string, int> second)
        {
            // 問題 21: 難易度 3 - Dictionary<TKey, TValue> の更新
            // 2つの Dictionary<string, int> を結合し、同じキーがある場合は値を合計した新しい Dictionary を返してください。
            // first と second 自体は変更しないでください。
            Dictionary<string, int> result = new Dictionary<string, int>();

            foreach (KeyValuePair<string, int> item in first)
            {
                if (!second.ContainsKey(item.Key))
                {
                    result[item.Key] = item.Value;
                }
                else
                {
                    result[item.Key] = item.Value + second[item.Key];
                }
            }

            foreach (KeyValuePair<string, int> item in second)
            {
                if (!first.ContainsKey(item.Key))
                {
                    result[item.Key] = item.Value;
                }
            }

            return result;
        }

        public static string FindMostFrequentWord(IEnumerable<string> words)
        {
            // 問題 22: 難易度 4 - 正規化、Dictionary、同率時の扱い
            // words に含まれる単語のうち、最も出現回数が多い単語を小文字で返してください。
            // 比較では大文字と小文字を区別せず、各単語の前後の空白は取り除いてください。
            // 空文字列になった単語は無視してください。
            // 最多の単語が複数ある場合は、最初にその最多回数へ到達した単語を返してください。
            // 有効な単語が1つもない場合は空文字列を返してください。
            Dictionary<string, int> count = new Dictionary<string, int>();
            int max = 0;
            string maxWord = string.Empty;

            if (words.Count() == 0) return "";

            foreach (string w in words)
            {
                string normailzed = w.ToLower().Trim();
                if (normailzed == "") continue;

                if (!count.ContainsKey(normailzed))
                {
                    count[normailzed] = 1;
                }
                else
                {
                    count[normailzed]++;
                }

                if (count[normailzed] > max)
                {
                    max = count[normailzed];
                    maxWord = normailzed;
                }
            }
            return maxWord;
        }

        public static bool AreParenthesesBalanced(string text)
        {
            // 問題 23: 難易度 4 - 状態を持つ走査
            // text に含まれる丸括弧 '(' と ')' の対応が正しければ true、正しくなければ false を返してください。
            // 丸括弧以外の文字は無視してください。
            // 途中で閉じ括弧が多くなる場合、または最後に開き括弧が残る場合は false です。
            int leftCount = 0;
            int rightCount = 0;

            foreach (char c in text)
            {
                if (c == '(')
                {
                    leftCount += 1;
                }
                else if (c == ')')
                {
                    rightCount += 1;
                }

                if (leftCount < rightCount)
                {
                    return false;
                }
            }
            if (leftCount == rightCount)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static List<int> CalculateRunningTotals(int[] numbers)
        {
            // 問題 24: 難易度 4 - 累積値
            // numbers の各位置までの累積和を List<int> として返してください。
            // 例: [3, -1, 4] の場合、[3, 2, 6] を返します。
            // numbers が空の場合は空の List<int> を返してください。
            List<int> result = new List<int>();
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
                result.Add(sum);
            }
            return result;
        }

        public static Dictionary<string, List<int>> GroupNumbersByParity(int[] numbers)
        {
            // 問題 25: 難易度 4 - Dictionary と List の組み合わせ
            // numbers を偶数と奇数に分け、"Even" と "Odd" をキーにした Dictionary<string, List<int>> を返してください。
            // 各 List では元の配列に出てきた順序を保ってください。
            // 偶数または奇数が1つもない場合でも、"Even" と "Odd" の両方のキーを必ず含めてください。
            Dictionary<string, List<int>> result = new Dictionary<string, List<int>>();
            List<int> evenArr = new List<int>();
            List<int> oddArr = new List<int>();

            foreach (int n in numbers)
            {
                if (n % 2 == 0)
                {
                    evenArr.Add(n);
                }
                else
                {
                    oddArr.Add(n);
                }
            }
            result["Even"] = evenArr;
            result["Odd"] = oddArr;

            return result;
        }
    }
}
