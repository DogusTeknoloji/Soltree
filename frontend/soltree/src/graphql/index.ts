import gql from 'graphql-tag';
import * as Urql from '@urql/vue';
export type Maybe<T> = T | null;
export type InputMaybe<T> = Maybe<T>;
export type Exact<T extends { [key: string]: unknown }> = { [K in keyof T]: T[K] };
export type MakeOptional<T, K extends keyof T> = Omit<T, K> & { [SubKey in K]?: Maybe<T[SubKey]> };
export type MakeMaybe<T, K extends keyof T> = Omit<T, K> & { [SubKey in K]: Maybe<T[SubKey]> };
export type Omit<T, K extends keyof T> = Pick<T, Exclude<keyof T, K>>;
/** All built-in and custom scalars, mapped to their actual values */
export type Scalars = {
  ID: string;
  String: string;
  Boolean: boolean;
  Int: number;
  Float: number;
  UUID: any;
};

export type Brand = {
  __typename?: 'Brand';
  id: Scalars['UUID'];
  name: Scalars['String'];
};

export type BrandCollectionSegment = {
  __typename?: 'BrandCollectionSegment';
  items?: Maybe<Array<Brand>>;
  /** Information to aid in pagination. */
  pageInfo: CollectionSegmentInfo;
};

export type BrandFilterInput = {
  and?: InputMaybe<Array<BrandFilterInput>>;
  id?: InputMaybe<ComparableGuidOperationFilterInput>;
  name?: InputMaybe<StringOperationFilterInput>;
  or?: InputMaybe<Array<BrandFilterInput>>;
};

export type BrandInsertRequestInput = {
  name: Scalars['String'];
};

export type BrandSortInput = {
  id?: InputMaybe<SortEnumType>;
  name?: InputMaybe<SortEnumType>;
};

export type BrandUpdateRequestInput = {
  id: Scalars['UUID'];
  name: Scalars['String'];
};

/** Information about the offset pagination. */
export type CollectionSegmentInfo = {
  __typename?: 'CollectionSegmentInfo';
  /** Indicates whether more items exist following the set defined by the clients arguments. */
  hasNextPage: Scalars['Boolean'];
  /** Indicates whether more items exist prior the set defined by the clients arguments. */
  hasPreviousPage: Scalars['Boolean'];
};

export type ComparableGuidOperationFilterInput = {
  eq?: InputMaybe<Scalars['UUID']>;
  gt?: InputMaybe<Scalars['UUID']>;
  gte?: InputMaybe<Scalars['UUID']>;
  in?: InputMaybe<Array<Scalars['UUID']>>;
  lt?: InputMaybe<Scalars['UUID']>;
  lte?: InputMaybe<Scalars['UUID']>;
  neq?: InputMaybe<Scalars['UUID']>;
  ngt?: InputMaybe<Scalars['UUID']>;
  ngte?: InputMaybe<Scalars['UUID']>;
  nin?: InputMaybe<Array<Scalars['UUID']>>;
  nlt?: InputMaybe<Scalars['UUID']>;
  nlte?: InputMaybe<Scalars['UUID']>;
};

export type ComparableNullableOfGuidOperationFilterInput = {
  eq?: InputMaybe<Scalars['UUID']>;
  gt?: InputMaybe<Scalars['UUID']>;
  gte?: InputMaybe<Scalars['UUID']>;
  in?: InputMaybe<Array<InputMaybe<Scalars['UUID']>>>;
  lt?: InputMaybe<Scalars['UUID']>;
  lte?: InputMaybe<Scalars['UUID']>;
  neq?: InputMaybe<Scalars['UUID']>;
  ngt?: InputMaybe<Scalars['UUID']>;
  ngte?: InputMaybe<Scalars['UUID']>;
  nin?: InputMaybe<Array<InputMaybe<Scalars['UUID']>>>;
  nlt?: InputMaybe<Scalars['UUID']>;
  nlte?: InputMaybe<Scalars['UUID']>;
};

export type DeviceType = {
  __typename?: 'DeviceType';
  id: Scalars['UUID'];
  image?: Maybe<Scalars['String']>;
  name: Scalars['String'];
};

export type DeviceTypeCollectionSegment = {
  __typename?: 'DeviceTypeCollectionSegment';
  items?: Maybe<Array<DeviceType>>;
  /** Information to aid in pagination. */
  pageInfo: CollectionSegmentInfo;
};

export type DeviceTypeFilterInput = {
  and?: InputMaybe<Array<DeviceTypeFilterInput>>;
  id?: InputMaybe<ComparableGuidOperationFilterInput>;
  image?: InputMaybe<StringOperationFilterInput>;
  name?: InputMaybe<StringOperationFilterInput>;
  or?: InputMaybe<Array<DeviceTypeFilterInput>>;
};

export type DeviceTypeInsertRequestInput = {
  image: Scalars['String'];
  name: Scalars['String'];
};

export type DeviceTypeSortInput = {
  id?: InputMaybe<SortEnumType>;
  image?: InputMaybe<SortEnumType>;
  name?: InputMaybe<SortEnumType>;
};

export type DeviceTypeUpdateRequestInput = {
  id: Scalars['UUID'];
  image: Scalars['String'];
  name: Scalars['String'];
};

export type InsertResponse = {
  __typename?: 'InsertResponse';
  id: Scalars['UUID'];
};

export type Model = {
  __typename?: 'Model';
  brand?: Maybe<Brand>;
  brandId: Scalars['UUID'];
  deviceType?: Maybe<DeviceType>;
  deviceTypeId: Scalars['UUID'];
  id: Scalars['UUID'];
  name: Scalars['String'];
};

export type ModelCollectionSegment = {
  __typename?: 'ModelCollectionSegment';
  items?: Maybe<Array<Model>>;
  /** Information to aid in pagination. */
  pageInfo: CollectionSegmentInfo;
};

export type ModelFilterInput = {
  and?: InputMaybe<Array<ModelFilterInput>>;
  brand?: InputMaybe<BrandFilterInput>;
  brandId?: InputMaybe<ComparableNullableOfGuidOperationFilterInput>;
  deviceType?: InputMaybe<DeviceTypeFilterInput>;
  deviceTypeId?: InputMaybe<ComparableNullableOfGuidOperationFilterInput>;
  id?: InputMaybe<ComparableGuidOperationFilterInput>;
  name?: InputMaybe<StringOperationFilterInput>;
  or?: InputMaybe<Array<ModelFilterInput>>;
};

export type ModelInsertRequestInput = {
  brandId: Scalars['UUID'];
  deviceTypeId: Scalars['UUID'];
  name: Scalars['String'];
};

export type ModelSortInput = {
  brand?: InputMaybe<BrandSortInput>;
  brandId?: InputMaybe<SortEnumType>;
  deviceType?: InputMaybe<DeviceTypeSortInput>;
  deviceTypeId?: InputMaybe<SortEnumType>;
  id?: InputMaybe<SortEnumType>;
  name?: InputMaybe<SortEnumType>;
};

export type ModelUpdateRequestInput = {
  id: Scalars['UUID'];
  name: Scalars['String'];
};

export type Mutation = {
  __typename?: 'Mutation';
  deleteBrand: Scalars['Boolean'];
  deleteDeviceType: Scalars['Boolean'];
  deleteModel: Scalars['Boolean'];
  deleteSolution: Scalars['Boolean'];
  deleteSymptom: Scalars['Boolean'];
  deleteSymptomCategory: Scalars['Boolean'];
  insertBrand: InsertResponse;
  insertDeviceType: InsertResponse;
  insertModel: InsertResponse;
  insertSolution: InsertResponse;
  insertSymptom: InsertResponse;
  insertSymptomCategory: InsertResponse;
  updateBrand: Scalars['Boolean'];
  updateBrandModel: Scalars['Boolean'];
  updateDeviceType: Scalars['Boolean'];
  updateSolution: Scalars['Boolean'];
  updateSymptom: Scalars['Boolean'];
  updateSymptomCategory: Scalars['Boolean'];
};


export type MutationDeleteBrandArgs = {
  id: Scalars['UUID'];
};


export type MutationDeleteDeviceTypeArgs = {
  id: Scalars['UUID'];
};


export type MutationDeleteModelArgs = {
  id: Scalars['UUID'];
};


export type MutationDeleteSolutionArgs = {
  id: Scalars['UUID'];
};


export type MutationDeleteSymptomArgs = {
  id: Scalars['UUID'];
};


export type MutationDeleteSymptomCategoryArgs = {
  id: Scalars['UUID'];
};


export type MutationInsertBrandArgs = {
  request: BrandInsertRequestInput;
};


export type MutationInsertDeviceTypeArgs = {
  request: DeviceTypeInsertRequestInput;
};


export type MutationInsertModelArgs = {
  request: ModelInsertRequestInput;
};


export type MutationInsertSolutionArgs = {
  request: SolutionInsertRequestInput;
};


export type MutationInsertSymptomArgs = {
  request: SymptomInsertRequestInput;
};


export type MutationInsertSymptomCategoryArgs = {
  request: SymptomCategoryInsertRequestInput;
};


export type MutationUpdateBrandArgs = {
  request: BrandUpdateRequestInput;
};


export type MutationUpdateBrandModelArgs = {
  request: ModelUpdateRequestInput;
};


export type MutationUpdateDeviceTypeArgs = {
  request: DeviceTypeUpdateRequestInput;
};


export type MutationUpdateSolutionArgs = {
  request: SolutionUpdateRequestInput;
};


export type MutationUpdateSymptomArgs = {
  request: SymptomUpdateRequestInput;
};


export type MutationUpdateSymptomCategoryArgs = {
  request: SymptomCategoryUpdateRequestInput;
};

export type Query = {
  __typename?: 'Query';
  brands?: Maybe<BrandCollectionSegment>;
  deviceTypes?: Maybe<DeviceTypeCollectionSegment>;
  models?: Maybe<ModelCollectionSegment>;
  solutions?: Maybe<SolutionCollectionSegment>;
  symptomCategorys?: Maybe<SymptomCategoryCollectionSegment>;
  symptoms?: Maybe<SymptomCollectionSegment>;
};


export type QueryBrandsArgs = {
  order?: InputMaybe<Array<BrandSortInput>>;
  skip?: InputMaybe<Scalars['Int']>;
  take?: InputMaybe<Scalars['Int']>;
  where?: InputMaybe<BrandFilterInput>;
};


export type QueryDeviceTypesArgs = {
  order?: InputMaybe<Array<DeviceTypeSortInput>>;
  skip?: InputMaybe<Scalars['Int']>;
  take?: InputMaybe<Scalars['Int']>;
  where?: InputMaybe<DeviceTypeFilterInput>;
};


export type QueryModelsArgs = {
  order?: InputMaybe<Array<ModelSortInput>>;
  skip?: InputMaybe<Scalars['Int']>;
  take?: InputMaybe<Scalars['Int']>;
  where?: InputMaybe<ModelFilterInput>;
};


export type QuerySolutionsArgs = {
  order?: InputMaybe<Array<SolutionSortInput>>;
  skip?: InputMaybe<Scalars['Int']>;
  take?: InputMaybe<Scalars['Int']>;
  where?: InputMaybe<SolutionFilterInput>;
};


export type QuerySymptomCategorysArgs = {
  order?: InputMaybe<Array<SymptomCategorySortInput>>;
  skip?: InputMaybe<Scalars['Int']>;
  take?: InputMaybe<Scalars['Int']>;
  where?: InputMaybe<SymptomCategoryFilterInput>;
};


export type QuerySymptomsArgs = {
  order?: InputMaybe<Array<SymptomSortInput>>;
  skip?: InputMaybe<Scalars['Int']>;
  take?: InputMaybe<Scalars['Int']>;
  where?: InputMaybe<SymptomFilterInput>;
};

export type Solution = {
  __typename?: 'Solution';
  description: Scalars['String'];
  id: Scalars['UUID'];
  title: Scalars['String'];
};

export type SolutionCollectionSegment = {
  __typename?: 'SolutionCollectionSegment';
  items?: Maybe<Array<Solution>>;
  /** Information to aid in pagination. */
  pageInfo: CollectionSegmentInfo;
};

export type SolutionFilterInput = {
  and?: InputMaybe<Array<SolutionFilterInput>>;
  description?: InputMaybe<StringOperationFilterInput>;
  id?: InputMaybe<ComparableGuidOperationFilterInput>;
  or?: InputMaybe<Array<SolutionFilterInput>>;
  title?: InputMaybe<StringOperationFilterInput>;
};

export type SolutionInsertRequestInput = {
  description: Scalars['String'];
  title: Scalars['String'];
};

export type SolutionSortInput = {
  description?: InputMaybe<SortEnumType>;
  id?: InputMaybe<SortEnumType>;
  title?: InputMaybe<SortEnumType>;
};

export type SolutionUpdateRequestInput = {
  description: Scalars['String'];
  id: Scalars['UUID'];
  title: Scalars['String'];
};

export enum SortEnumType {
  Asc = 'ASC',
  Desc = 'DESC'
}

export type StringOperationFilterInput = {
  and?: InputMaybe<Array<StringOperationFilterInput>>;
  contains?: InputMaybe<Scalars['String']>;
  endsWith?: InputMaybe<Scalars['String']>;
  eq?: InputMaybe<Scalars['String']>;
  in?: InputMaybe<Array<InputMaybe<Scalars['String']>>>;
  ncontains?: InputMaybe<Scalars['String']>;
  nendsWith?: InputMaybe<Scalars['String']>;
  neq?: InputMaybe<Scalars['String']>;
  nin?: InputMaybe<Array<InputMaybe<Scalars['String']>>>;
  nstartsWith?: InputMaybe<Scalars['String']>;
  or?: InputMaybe<Array<StringOperationFilterInput>>;
  startsWith?: InputMaybe<Scalars['String']>;
};

export type Symptom = {
  __typename?: 'Symptom';
  id: Scalars['UUID'];
  name: Scalars['String'];
  symptomCategory?: Maybe<SymptomCategory>;
  symptomCategoryId: Scalars['UUID'];
};

export type SymptomCategory = {
  __typename?: 'SymptomCategory';
  id: Scalars['UUID'];
  name: Scalars['String'];
};

export type SymptomCategoryCollectionSegment = {
  __typename?: 'SymptomCategoryCollectionSegment';
  items?: Maybe<Array<SymptomCategory>>;
  /** Information to aid in pagination. */
  pageInfo: CollectionSegmentInfo;
};

export type SymptomCategoryFilterInput = {
  and?: InputMaybe<Array<SymptomCategoryFilterInput>>;
  id?: InputMaybe<ComparableGuidOperationFilterInput>;
  name?: InputMaybe<StringOperationFilterInput>;
  or?: InputMaybe<Array<SymptomCategoryFilterInput>>;
};

export type SymptomCategoryInsertRequestInput = {
  name: Scalars['String'];
};

export type SymptomCategorySortInput = {
  id?: InputMaybe<SortEnumType>;
  name?: InputMaybe<SortEnumType>;
};

export type SymptomCategoryUpdateRequestInput = {
  id: Scalars['UUID'];
  name: Scalars['String'];
};

export type SymptomCollectionSegment = {
  __typename?: 'SymptomCollectionSegment';
  items?: Maybe<Array<Symptom>>;
  /** Information to aid in pagination. */
  pageInfo: CollectionSegmentInfo;
};

export type SymptomFilterInput = {
  and?: InputMaybe<Array<SymptomFilterInput>>;
  id?: InputMaybe<ComparableGuidOperationFilterInput>;
  name?: InputMaybe<StringOperationFilterInput>;
  or?: InputMaybe<Array<SymptomFilterInput>>;
  symptomCategory?: InputMaybe<SymptomCategoryFilterInput>;
  symptomCategoryId?: InputMaybe<ComparableNullableOfGuidOperationFilterInput>;
};

export type SymptomInsertRequestInput = {
  name: Scalars['String'];
  symptomCategoryId: Scalars['UUID'];
};

export type SymptomSortInput = {
  id?: InputMaybe<SortEnumType>;
  name?: InputMaybe<SortEnumType>;
  symptomCategory?: InputMaybe<SymptomCategorySortInput>;
  symptomCategoryId?: InputMaybe<SortEnumType>;
};

export type SymptomUpdateRequestInput = {
  id: Scalars['UUID'];
  name: Scalars['String'];
  symptomCategoryId: Scalars['UUID'];
};

export type GetBrandsQueryVariables = Exact<{
  skip?: InputMaybe<Scalars['Int']>;
  take?: InputMaybe<Scalars['Int']>;
}>;


export type GetBrandsQuery = { __typename?: 'Query', brands?: { __typename?: 'BrandCollectionSegment', items?: Array<{ __typename?: 'Brand', id: any, name: string }> | null } | null };

export type GetModelsByBrandIdQueryVariables = Exact<{
  brandId?: InputMaybe<Scalars['UUID']>;
}>;


export type GetModelsByBrandIdQuery = { __typename?: 'Query', models?: { __typename?: 'ModelCollectionSegment', items?: Array<{ __typename?: 'Model', name: string, id: any, brandId: any }> | null } | null };

export type DeviceTypeImageQueryVariables = Exact<{ [key: string]: never; }>;


export type DeviceTypeImageQuery = { __typename?: 'Query', deviceTypes?: { __typename?: 'DeviceTypeCollectionSegment', items?: Array<{ __typename?: 'DeviceType', id: any, name: string, image?: string | null }> | null } | null };


export const GetBrandsDocument = gql`
    query getBrands($skip: Int, $take: Int) {
  brands(skip: $skip, take: $take) {
    items {
      id
      name
    }
  }
}
    `;

export function useGetBrandsQuery(options: Omit<Urql.UseQueryArgs<never, GetBrandsQueryVariables>, 'query'> = {}) {
  return Urql.useQuery<GetBrandsQuery>({ query: GetBrandsDocument, ...options });
};
export const GetModelsByBrandIdDocument = gql`
    query getModelsByBrandId($brandId: UUID) {
  models(where: {brandId: {eq: $brandId}}) {
    items {
      name
      id
      brandId
    }
  }
}
    `;

export function useGetModelsByBrandIdQuery(options: Omit<Urql.UseQueryArgs<never, GetModelsByBrandIdQueryVariables>, 'query'> = {}) {
  return Urql.useQuery<GetModelsByBrandIdQuery>({ query: GetModelsByBrandIdDocument, ...options });
};
export const DeviceTypeImageDocument = gql`
    query deviceTypeImage {
  deviceTypes {
    items {
      id
      name
      image
    }
  }
}
    `;

export function useDeviceTypeImageQuery(options: Omit<Urql.UseQueryArgs<never, DeviceTypeImageQueryVariables>, 'query'> = {}) {
  return Urql.useQuery<DeviceTypeImageQuery>({ query: DeviceTypeImageDocument, ...options });
};